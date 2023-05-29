//    THE SAMPLE SOLUTION IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//    SOFTWARE

using System;
using Microsoft.Xrm.Sdk;

namespace AutoCoE.Extensibility.Plugins
{
    class OptionSetHelper
    {
        public static OptionSetValue GetOnlineStatusOptionSetValue(string onlineStatus)
        {
            // Online = 411140000,
            // Offline = 411140001,
            // MissedHeartBeat = 411140002
            // NotRegistered = 411140003
            // UnableToGetStatus = 411140004

            OptionSetValue value;

            switch (onlineStatus)
            {
                case "Online":
                    value = new OptionSetValue((Int32)autocoe_MachineStatus_Enum.Online);
                    break;
                case "Offline":
                    value = new OptionSetValue((Int32)autocoe_MachineStatus_Enum.Offline);
                    break;
                case "NotRegistered": // Action needed
                    value = new OptionSetValue((Int32)autocoe_MachineStatus_Enum.NotRegistered);
                    break;
                case "UnableToGetStatus": // Network issue
                    value = new OptionSetValue((Int32)autocoe_MachineStatus_Enum.UnableToGetStatus);
                    break;
                default: // MissedHeartBeat
                    value = new OptionSetValue((Int32)autocoe_MachineStatus_Enum.MissedHeartbeat);
                    break;
            }
            return value;
        }
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum autocoe_MachineStatus_Enum
    {
        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Unable To Get Status", 4)]
        UnableToGetStatus = 411140004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Not Registered", 3)]
        NotRegistered = 411140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Missed Heartbeat", 2)]
        MissedHeartbeat = 411140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Offline", 1)]
        Offline = 411140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Online", 0)]
        Online = 411140000

    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum autocoe_MachineStatus_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0)]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1)]
        Inactive = 2,
    }
    
    internal sealed class EntityOptionSetEnum
    {

        [System.Diagnostics.DebuggerNonUserCode()]
        public static System.Nullable<int> GetEnum(Microsoft.Xrm.Sdk.Entity entity, string attributeLogicalName)
        {
            if (entity.Attributes.ContainsKey(attributeLogicalName))
            {
                Microsoft.Xrm.Sdk.OptionSetValue value = entity.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>(attributeLogicalName);
                if (value != null)
                {
                    return value.Value;
                }
            }
            return null;
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        public static System.Collections.Generic.IEnumerable<T> GetMultiEnum<T>(Microsoft.Xrm.Sdk.Entity entity, string attributeLogicalName)

        {
            Microsoft.Xrm.Sdk.OptionSetValueCollection value = entity.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValueCollection>(attributeLogicalName);
            System.Collections.Generic.List<T> list = new System.Collections.Generic.List<T>();
            if (value == null)
            {
                return list;
            }
            list.AddRange(System.Linq.Enumerable.Select(value, v => (T)(object)v.Value));
            return list;
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        public static Microsoft.Xrm.Sdk.OptionSetValueCollection GetMultiEnum<T>(Microsoft.Xrm.Sdk.Entity entity, string attributeLogicalName, System.Collections.Generic.IEnumerable<T> values)

        {
            if (values == null)
            {
                return null;
            }
            Microsoft.Xrm.Sdk.OptionSetValueCollection collection = new Microsoft.Xrm.Sdk.OptionSetValueCollection();
            collection.AddRange(System.Linq.Enumerable.Select(values, v => new Microsoft.Xrm.Sdk.OptionSetValue((int)(object)v)));
            return collection;
        }
    }

    /// <summary>
    /// Attribute to handle storing the OptionSet's Metadata.
    /// </summary>
    [System.AttributeUsageAttribute(System.AttributeTargets.Field)]
    public sealed class OptionSetMetadataAttribute : System.Attribute
    {

        /// <summary>
        /// Color of the OptionSetValue.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Description of the OptionSetValue.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Display order index of the OptionSetValue.
        /// </summary>
        public int DisplayIndex { get; set; }

        /// <summary>
        /// External value of the OptionSetValue.
        /// </summary>
        public string ExternalValue { get; set; }

        /// <summary>
        /// Name of the OptionSetValue.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionSetMetadataAttribute"/> class.
        /// </summary>
        /// <param name="name">Name of the value.</param>
        /// <param name="displayIndex">Display order index of the value.</param>
        /// <param name="color">Color of the value.</param>
        /// <param name="description">Description of the value.</param>
        /// <param name="externalValue">External value of the value.</param>
        [System.Diagnostics.DebuggerNonUserCode()]
        public OptionSetMetadataAttribute(string name, int displayIndex, string color = null, string description = null, string externalValue = null)
        {
            this.Color = color;
            this.Description = description;
            this.ExternalValue = externalValue;
            this.DisplayIndex = displayIndex;
            this.Name = name;
        }
    }

    /// <summary>
    /// Extension class to handle retrieving of OptionSetMetadataAttribute.
    /// </summary>
    public static class OptionSetExtension
    {

        /// <summary>
        /// Returns the OptionSetMetadataAttribute for the given enum value
        /// </summary>
        /// <typeparam name="T">OptionSet Enum Type</typeparam>
        /// <param name="value">Enum Value with OptionSetMetadataAttribute</param>
        [System.Diagnostics.DebuggerNonUserCode()]
#pragma warning disable CS3024 // Constraint type is not CLS-compliant
        public static OptionSetMetadataAttribute GetMetadata<T>(this T value)
#pragma warning restore CS3024 // Constraint type is not CLS-compliant
            where T : struct, System.IConvertible
        {
            System.Type enumType = typeof(T);
            if (!enumType.IsEnum)
            {
                throw new System.ArgumentException("T must be an enum!");
            }
            System.Reflection.MemberInfo[] members = enumType.GetMember(value.ToString());
            for (int i = 0; (i < members.Length); i++
            )
            {
                System.Attribute attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(members[i], typeof(OptionSetMetadataAttribute));
                if (attribute != null)
                {
                    return ((OptionSetMetadataAttribute)(attribute));
                }
            }
            throw new System.ArgumentException("T must be an enum adorned with an OptionSetMetadataAttribute!");
        }
    }
}
