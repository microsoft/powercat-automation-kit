//    THE SAMPLE SOLUTION IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//    SOFTWARE


using AutoCoE.Extensibility.Plugins.DataModel;
using Microsoft.Xrm.Sdk;
using System;
using System.Linq;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Microsoft.Crm.Sdk.Messages;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Xml;

namespace AutoCoE.Extensibility.Plugins.PluginHelper
{
    /// <summary>
    /// Plugin Utility class with helper functions and structures
    /// </summary>
    class PluginUtility
    {
        /// <summary>
        /// Serialize custom Objects
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize<T>(T obj)
        {
            using (var stream = new MemoryStream())
            {
                GetSerializer<T>().WriteObject(stream, obj);
                return Encoding.UTF8.GetString(stream.ToArray());
            }
        }

        /// <summary>
        /// Deserializing JSON to custom Objects
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string json)
        {
            using (var stream = new MemoryStream())
            {
                using (var writer = new StreamWriter(stream))
                {
                    writer.Write(json);
                    writer.Flush();
                    stream.Position = 0;
                    return (T)GetSerializer<T>().ReadObject(stream);
                }
            }
        }

        /// <summary>
        ///  .NET internal serializer / deserializer which allows us to avoid 3rd party nuget package usage such as Newtonsoft
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static DataContractJsonSerializer GetSerializer<T>()
        {
            var settings = new DataContractJsonSerializerSettings
            {
                UseSimpleDictionaryFormat = true
            };

            return new DataContractJsonSerializer(typeof(T), settings);
        }

        public static string GetDesktopFlowScriptById(Guid workflowid, IOrganizationService service)
        {
            DataverseServiceContext svcContext = new DataverseServiceContext(service);

            var desktopFlow = (from flow in svcContext.WorkflowSet
                               where (flow.WorkflowId == workflowid)
                               select new
                               {
                                   flowId = flow.WorkflowId,
                                   flowName = flow.Name,
                                   definition = flow.ClientData
                               }).FirstOrDefault();


            if (desktopFlow != null && !string.IsNullOrEmpty(desktopFlow.definition))
            {

                using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(desktopFlow.definition)))
                {

                    DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings()
                    {
                        UseSimpleDictionaryFormat = true
                    };
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(WorkflowClientData), settings);
                    var clientData = (WorkflowClientData)ser.ReadObject(stream);

                    return clientData.properties.definition.package;
                }
            }
            else
                return string.Empty;
        }
        public static string ExtractDesktopFlowScript(string clientData, bool formatScript)
        {
            if (!string.IsNullOrEmpty(clientData))
            {
                var base64EncodedBytes = System.Convert.FromBase64String(clientData);

                Stream data = new MemoryStream(base64EncodedBytes);
                ZipArchive archive = new ZipArchive(data);

                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    using (StreamReader sr = new StreamReader(entry.Open()))
                    {
                        if (!formatScript)
                        {
                            return sr.ReadToEnd().Replace("\0", "");
                        }
                        else
                        {
                            StringBuilder sb = new StringBuilder();

                            var multiLineText = Regex.Split(sr.ReadToEnd().Replace("\0", ""), "\r\n|\r|\n", RegexOptions.Multiline);

                            foreach (string value in multiLineText)
                            {
                                sb.Append(value);
                                sb.Append(' ');
                            }
                            return sb.ToString();
                        }
                    }
                }
                return "";
            }
            else
            {
                return "";
            }
        }

        public static string ExtractAdditionalContext(IOrganizationService service, Guid flowSessionId)
        {
            InitializeFileBlocksDownloadRequest ifbdRequest = new InitializeFileBlocksDownloadRequest
            {
                Target = new EntityReference("flowsession", flowSessionId),
                FileAttributeName = "additionalcontext"
            };

            InitializeFileBlocksDownloadResponse ifbdResponse = (InitializeFileBlocksDownloadResponse)service.Execute(ifbdRequest);

            DownloadBlockRequest dbRequest = new DownloadBlockRequest
            {
                FileContinuationToken = ifbdResponse.FileContinuationToken
            };

            var resdbResponsep = (DownloadBlockResponse)service.Execute(dbRequest);
            return Encoding.UTF8.GetString(resdbResponsep.Data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="originalDesktopFlowScript"></param>
        /// <returns></returns>
        public static string RemoveVariablesFromDesktopFlowScript(string originalDesktopFlowScript)
        {
            string script;

            // Check first if we have a desktop flow without input or output parameters
            var matchParameterCases = FindStringPositionWithRegex(originalDesktopFlowScript, @"(\@SENSITIVE: \[] \b)(?!.*\1)", true);
            if (matchParameterCases.Length > 0) // No input or output params defined in script
            {
                // Remove variable definition from script as these might contain sensitive information in them
                script = originalDesktopFlowScript.Substring(matchParameterCases.Index + matchParameterCases.Length, originalDesktopFlowScript.Length - (matchParameterCases.Index + matchParameterCases.Length));
            }
            else  // Input or output params defined in script
            {
                // The regex function is used to find the end of the Sensitive, Input and Output Variables so we can remove them in the next step
                matchParameterCases = FindStringPositionWithRegex(originalDesktopFlowScript, @"(\ }  \b)(?!.*\1)|(\] \b)(?!.*\1)", true);
                // Remove variable definition from script as these might contain sensitive information 
                script = originalDesktopFlowScript.Substring(matchParameterCases.Index + matchParameterCases.Length, originalDesktopFlowScript.Length - (matchParameterCases.Index + matchParameterCases.Length));
            }

            return script;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="pattern"></param>
        /// <param name="ignoreCase"></param>
        /// <returns></returns>
        public static Match FindStringPositionWithRegex(string inputString, string pattern, bool ignoreCase)
        {
            try
            {
                return Regex.Match(inputString, pattern,
                                   ignoreCase ? RegexOptions.IgnoreCase | RegexOptions.Compiled : RegexOptions.Compiled,
                                   TimeSpan.FromSeconds(1));
            }
            catch (Exception ex)
            {
                throw new Exception("FindStringPositionWithRegex threw an exception: ", ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="pattern"></param>
        /// <param name="ignoreCase"></param>
        /// <returns></returns>
        public static int FindStringOccurrencesWithRegEx(string inputString, string pattern, bool ignoreCase)
        {
            try
            {
                return Regex.Matches(inputString, pattern,
                                     ignoreCase ? RegexOptions.IgnoreCase | RegexOptions.Compiled : RegexOptions.Compiled,
                                     TimeSpan.FromSeconds(1)).Count;
            }
            catch (Exception ex)
            {
                throw new Exception("FindStringOccurrencesWithRegEx threw an exception: ", ex);
            }
        }

        public static RegexResult RunRegExOverDesktopFlowScript(string inputString, string pattern, bool isMatch, bool ignoreCase)
        {
            try
            {
                if (isMatch)
                {
                    Regex regexMatch = new Regex(pattern,
                        ignoreCase ? RegexOptions.IgnoreCase | RegexOptions.Compiled : RegexOptions.Compiled,
                        TimeSpan.FromSeconds(1));

                    return regexMatch.IsMatch(inputString) ? new RegexResult() { MatchFound = true} : new RegexResult() { MatchFound = false};
                }

                var regexMatches = Regex.Matches(inputString, pattern,
                                               ignoreCase ? RegexOptions.IgnoreCase | RegexOptions.Compiled : RegexOptions.Compiled,
                                               TimeSpan.FromSeconds(1));

                if (regexMatches.Count == 0)
                    return new RegexResult();
                else
                {
                    RegexResult results = new RegexResult();
                    List<MatchResult> matchresults = new List<MatchResult>();

                    foreach (Match m in regexMatches)
                    {
                        MatchResult mresult = new MatchResult();
                        mresult.MatchGroup = m.Value;
                        mresult.Index = m.Index;
                        matchresults.Add(mresult);
                    }

                    var uniqueMatchGroups = matchresults.SelectMany(x => x.MatchGroup.Select(y => new
                    {
                        matchGroup = x.MatchGroup
                    }))
                    .GroupBy(x => x.matchGroup)
                    .ToList();

                    results.MatchResults = matchresults;
                    results.TotalOccurrences = matchresults.Count;
                    results.UniqueMatchGroupCount = uniqueMatchGroups.Count;

                    return results;
                }
            }
            catch (RegexMatchTimeoutException ex)
            {
                throw new InvalidPluginExecutionException("RunRegExOverDesktopFlowScript threw an exception: ", ex);
            }
        }

        private static string GetValueNode(XmlDocument doc, string key)
        {
            XmlNode node = doc.SelectSingleNode(String.Format("Settings/setting[@name='{0}']", key));

            if (node != null)
            {
                return node.SelectSingleNode("value").InnerText;
            }
            return string.Empty;
        }

        public static Guid GetConfigDataGuid(XmlDocument doc, string label)
        {
            string tempString = GetValueNode(doc, label);

            if (tempString != string.Empty)
            {
                return new Guid(tempString);
            }
            return Guid.Empty;
        }

        public static bool GetConfigDataBool(XmlDocument doc, string label)
        {
            bool retVar;

            if (bool.TryParse(GetValueNode(doc, label), out retVar))
            {
                return retVar;
            }
            else
            {
                return false;
            }
        }

        public static int GetConfigDataInt(XmlDocument doc, string label)
        {
            int retVar;

            if (int.TryParse(GetValueNode(doc, label), out retVar))
            {
                return retVar;
            }
            else
            {
                return -1;
            }
        }

        public static string GetConfigDataString(XmlDocument doc, string label)
        {
            return GetValueNode(doc, label);
        }

        public static object GetAttibutevalue(Entity entity, string attributeName, Type type) {
            return entity.Contains(attributeName) ? entity[attributeName] : 0;
        }

        // Build the API signature
        public static string BuildSignature(string message, string secret)
        {
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = Convert.FromBase64String(secret);
            byte[] messageBytes = encoding.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hash = hmacsha256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hash);
            }
        }

        // Send a request to the POST API endpoint
        public static void PostAzureLogAnalyticsData(string tableName, string workspaceId, string workspacePrimaryKey, string alaAPIVersion, string json)
        {
            try
            {
                // Create a hash for the API signature
                var datestring = DateTime.UtcNow.ToString("r");
                var jsonBytes = Encoding.UTF8.GetBytes(json);
                string stringToHash = "POST\n" + jsonBytes.Length + "\napplication/json\n" + "x-ms-date:" + datestring + "\n/api/logs";
                string hashedString = BuildSignature(stringToHash, workspacePrimaryKey);
                string signature = "SharedKey " + workspaceId + ":" + hashedString;

                // Send a request to the POST API endpoint
                string postUrl = "https://" + workspaceId + ".ods.opinsights.azure.com/api/logs?api-version=" + alaAPIVersion;

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    client.DefaultRequestHeaders.Add("Log-Type", tableName);
                    client.DefaultRequestHeaders.Add("Authorization", signature);
                    client.DefaultRequestHeaders.Add("x-ms-date", datestring);

                    using (HttpContent httpContent = new StringContent(json, Encoding.UTF8))
                    {
                        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                        Task<HttpResponseMessage> insertLogDataResponse = client.PostAsync(new Uri(postUrl), httpContent);

                        HttpContent responseContent = insertLogDataResponse.Result.Content;
                        string result = responseContent.ReadAsStringAsync().Result;
                    }
                }
            }
            catch (Exception excep)
            {
                throw new InvalidOperationException($"An exception occurred when posting to Azure Log Analytics. Details: {excep.Message}");
            }

        }
        public static string CleanInvalidChars(string strInput)
        {
            if (string.IsNullOrWhiteSpace(strInput))
            {
                return strInput;
            }
            // From xml spec valid chars:
            // #x9 | #xA | #xD | [#x20-#xD7FF] | [#xE000-#xFFFD] | [#x10000-#x10FFFF]    
            // any Unicode character, excluding the surrogate blocks, FFFE, and FFFF.
            string RegularExp = @"[^\x09\x0A\x0D\x20-\xD7FF\xE000-\xFFFD\x10000-x10FFFF]";
            return Regex.Replace(strInput, RegularExp, String.Empty);
        }
    }

    public class BearerToken
    {
        public string token_type { get; set; }
        public string expires_in { get; set; }
        public string ext_expires_in { get; set; }
        public string expires_on { get; set; }
        public string not_before { get; set; }
        public string resource { get; set; }
        public string access_token { get; set; }
    }

    /// <summary>
    /// Custom object for MachineStatus records
    /// </summary>
    public class MachineStatus
    {
        public string machineId { get; set; }
        public string status { get; set; }
        public ErrorDetails errorInfo { get; set; }

    }

    /// <summary>
    /// Custom object for ErroDetails in Machine Status records
    /// </summary>
    public class ErrorDetails
    {
        public string errorCode { get; set; }
        public object message { get; set; }
        public object details { get; set; }
    }

    /// <summary>
    /// Custom object for Flow Machine records from Dataverse
    /// </summary>
    public class DataverseFlowMachine
    {
        public string flowmachineid { get; set; }
        public string name { get; set; }
    }

    /// <summary>
    /// Custom object for Machine Status Log records from Dataverse
    /// </summary>
    public class DataverseMachineStatus
    {
        public string type { get; set; }
        public string id { get; set; }
        public string etag { get; set; }
        public string editLink { get; set; }
        public string autocoe_environmentuniquename { get; set; }
        public string autocoe_initiatinguserid { get; set; }
        public string autocoe_laststatusupdatetime { get; set; }
        public string autocoe_laststatusupdatetime_formatted { get; set; }
        public string autocoe_laststatusupdatetimetype { get; set; }
        public string autocoe_machineid { get; set; }
        public string autocoe_name { get; set; }
        public string autocoe_onlinestatus_formatted { get; set; }
        public int autocoe_onlinestatus { get; set; }
        public string autocoe_machinestatusidtype { get; set; }
        public string autocoe_machinestatusid { get; set; }
    }
    public class Definition
    {
        public string package { get; set; }
        public string name { get; set; }
    }

    public class Properties
    {
        public Definition definition { get; set; }
    }
    public class WorkflowClientData
    {
        public Properties properties { get; set; }
    }

    public class MatchResult
    {
        public string MatchGroup { get; set; }
        public int Index { get; set; }
    }

    public class RegexResult
    {
        public List<MatchResult> MatchResults { get; set; }
        public int TotalOccurrences { get; set; }
        public int UniqueMatchGroupCount { get; set; }
        public bool MatchFound { get; set; }
    }

    public class PADActionLog
    {
        public List<PADAction> actions { get; set; }
    }

    public class PADAction
    {
        public string flowsessionid { get; set; }
        public string name { get; set; }
        public string systemActionName { get; set; }
        public string systemModuleName { get; set; }
        public string localizedModuleName { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public int index { get; set; }
        public string functionName { get; set; }
        public bool insideErrorHandling { get; set; }
        public string status { get; set; }
        public Error error { get; set; }
        public string errorCode { get; set; }
        public string errorMessage { get; set; }
    }
    public class Error
    {
        public string code { get; set; }
        public string correlationId { get; set; }
        public string message { get; set; }
    }
    public class FlowSessionLog
    {
        public DateTime? desktopflowcompletiondate { get; set; }
        public string desktopflowid { get; set; }
        public string desktopflowname { get; set; }
        public string flowsessionid { get; set; }
        public string environmentuniquename { get; set; }
        public DateTime? cloudflowstartdate { get; set; }
        public string environmentinstanceurl { get; set; }
        public string cloudflowstatus { get; set; }
        public string flowsessionlogid { get; set; }
        public DateTime? cloudflowcompletiondate { get; set; }
        public string cloudflowid { get; set; }
        public string cloudflowname { get; set; }
        public string trigger { get; set; }
        public string hostname { get; set; }
        public CloudFlowErrorRemidiationDetails cloudflowerrorremediationdetails { get; set; }
        public string cloudflowerrorremediationtype { get; set; }
        public string cloudflowerrorsubject { get; set; }
        public string cloudflowerrordescription { get; set; }
        public string cloudflowresubmiturl { get; set; }
        public string desktopflowstatus { get; set; }
        public DateTime? desktopflowstartdate { get; set; }
        public string cloudflowrunid { get; set; }
        public string environmentname { get; set; }
        public string environmentid { get; set; }
        public string environmentbaseurl { get; set; }
        public string automationownerdepartment { get; set; }
        public string automationowneremail { get; set; }
        public string automationowner { get; set; }
        public string automationownerbu { get; set; }
    }

    public class OperationOutputs
    {
        public string code { get; set; }
        public string message { get; set; }
    }

    public class CloudFlowErrorRemidiationDetails
    {
        public string remediationType { get; set; }
        public string errorSubject { get; set; }
        public string errorDescription { get; set; }
        public OperationOutputs operationOutputs { get; set; }
        public string searchText { get; set; }
    }
    /// <summary>
    /// Represents a source of entities bound to a CRM service. It tracks and manages changes made to the retrieved entities.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.82")]
    public partial class DataverseServiceContext : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public DataverseServiceContext(Microsoft.Xrm.Sdk.IOrganizationService service) :
                base(service)
        {
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="AutoCoE.Extensibility.Plugins.DataModel.autocoe_DesktopFlowDefinition"/> entities.
        /// </summary>
        public System.Linq.IQueryable<autocoe_DesktopFlowDefinition> autocoe_DesktopFlowDefinition
        {
            get
            {
                return this.CreateQuery<autocoe_DesktopFlowDefinition>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="AutoCoE.Extensibility.Plugins.DataModel.Workflow"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Workflow> WorkflowSet
        {
            get
            {
                return this.CreateQuery<Workflow>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="AutoCoE.Extensibility.Plugins.DataModel.autocoe_DesktopFlowDLPImpactProfile"/> entities.
        /// </summary>
        public System.Linq.IQueryable<AutoCoE.Extensibility.Plugins.DataModel.autocoe_DesktopFlowDLPImpactProfile> autocoe_DesktopFlowDLPImpactProfileSet
        {
            get
            {
                return this.CreateQuery<AutoCoE.Extensibility.Plugins.DataModel.autocoe_DesktopFlowDLPImpactProfile>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="AutoCoE.Extensibility.Plugins.DataModel.autocoe_DesktopFlowAction"/> entities.
        /// </summary>
        public System.Linq.IQueryable<AutoCoE.Extensibility.Plugins.DataModel.autocoe_DesktopFlowAction> autocoe_DesktopFlowActionSet
        {
            get
            {
                return this.CreateQuery<AutoCoE.Extensibility.Plugins.DataModel.autocoe_DesktopFlowAction>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="AutoCoE.Extensibility.Plugins.DataModel.autocoe_FlowSessionLog"/> entities.
        /// </summary>
        public System.Linq.IQueryable<AutoCoE.Extensibility.Plugins.DataModel.autocoe_FlowSessionLog> autocoe_FlowSessionLogSet
        {
            get
            {
                return this.CreateQuery<AutoCoE.Extensibility.Plugins.DataModel.autocoe_FlowSessionLog>();
            }
        }
    }
}
