using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using HtmlAgilityPack;
using System.Data;
using System.Text;
using Xunit.Abstractions;

namespace ARMTemplate.Tests;

public class AzureSynapseTests
{
    private string testFile = String.Empty;
    private readonly ITestOutputHelper _output;

    public static Dictionary<string, string> HttpCache = new Dictionary<string, string>();

    private double BYTE_TO_GIGABYTE = (1024 * 1024 * 1024); // To KB -> MB -> GB

    public AzureSynapseTests(ITestOutputHelper output) {
        _output = output;
        string binaryFolder = GetType().Assembly.Location;
        string? location = Path.GetDirectoryName(binaryFolder != null ? binaryFolder : String.Empty);
        if ( !string.IsNullOrEmpty(location))
        {
            testFile = Path.Combine(location, "..\\..\\..\\..\\..\\ARMTemplate\\azuredeploy.json");
        }
    }

    [Fact]
    public void TestFileExists()
    {
        // Arrange
        

        // Act
        

        // Assert
        Assert.True(File.Exists(testFile));
    }

    [Fact]
    public void CanLoad()
    {
        Assert.NotNull(JObject.Parse(File.ReadAllText(testFile)));
    }

    
    [Fact]
    public void SparkDeploymentDefaultTrue()
    {
        // Arrange
        var json = JObject.Parse(File.ReadAllText(testFile));

        // Act
        var match = json.SelectTokens("parameters.sparkDeployment").FirstOrDefault() as JObject;


        // Assert
        Assert.NotNull(match);
        var defaultValue = match.Properties().Where(p => p.Name == "defaultValue").FirstOrDefault();
        Assert.NotNull(defaultValue);
        Assert.Equal("true", defaultValue.Value.Value<string>());
    }
    

    [Fact]
    public void AllowedResourceTypes()
    {
        // Arrange
        var json = JObject.Parse(File.ReadAllText(testFile));
        var allowed = new List<string>() {
            "Microsoft.Storage/storageAccounts",
            "Microsoft.Synapse/workspaces",
            "Microsoft.Synapse/workspaces/bigDataPools",
            "Microsoft.Consumption/budgets"
        };

        // Act
        var match = json.SelectTokens("resources").FirstOrDefault() as JArray;

        Assert.NotNull(match);

        // Assert
        foreach (JObject item in match.Children())
        {
            var typeProperty = item.Property("type")?.Value.Value<string>();
            if (!string.IsNullOrEmpty(typeProperty)) { 
                Assert.Contains(typeProperty, allowed);
            }
        }
    }

    [Fact]
    public void StorageAccountIsV2()
    {
        // Arrange
        var json = JObject.Parse(File.ReadAllText(testFile));

        // Act
        var resources = json.SelectTokens("resources").FirstOrDefault() as JArray;
        var match = resources?.Where(r => r is JObject && ((JObject)r).Property("type")?.Value.Value<string>() == "Microsoft.Storage/storageAccounts").FirstOrDefault() as JObject;

        Assert.NotNull(match);

        // Assert
        var kind = match.Property("kind")?.Value.Value<string>();
        Assert.Equal("StorageV2", kind);
    }

    [Fact]
    public void SparkNodeSizeDefaultSmall()
    {
        // Arrange
        var json = JObject.Parse(File.ReadAllText(testFile));

        // Act
        var match = json.SelectTokens("$..sparkNodeSize").FirstOrDefault() as JObject;
        
        Assert.NotNull(match);

        // Assert
        var defaultValue = match.Property("defaultValue")?.Value.Value<string>();
        Assert.Equal("Small", defaultValue);
    }

    [Fact]
    public void SparkPoolProperties()
    {
        // Arrange
        var json = JObject.Parse(File.ReadAllText(testFile));

        // Act
        var resources = json.SelectTokens("resources").FirstOrDefault() as JArray;
        var match = resources?.Where(r => r is JObject && ((JObject)r).Property("type")?.Value.Value<string>() == "Microsoft.Synapse/workspaces/bigDataPools").FirstOrDefault() as JObject;

        Assert.NotNull(match);

        // Assert
        var proprties = match.Property("properties")?.Value as JObject;

        Assert.Equal("MemoryOptimized", proprties?.Property("nodeSizeFamily")?.Value.Value<string>());
        Assert.Equal("[parameters('sparkNodeSize')]", proprties?.Property("nodeSize")?.Value.Value<string>());
    }

    [Theory]
    [InlineData("workflow")]
    [InlineData("flowsession")]
    [InlineData("flowmachine")]
    [InlineData("flowmachinegroup")]
    public async Task SizeMinGreaterThanZero(string table)
    {
        // Arrange

        // Act
        var size = await GetRecordSize(table, "csv", CostType.Minimum);

        // Assert
        Assert.True(size > 0);
    }

    [Theory]
    [InlineData("workflow")]
    [InlineData("flowsession")]
    [InlineData("flowmachine")]
    [InlineData("flowmachinegroup")]
    public async Task SizeMaxGreaterThanZero(string table)
    {
        // Arrange

        // Act
        var size = await GetRecordSize(table, "csv", CostType.Maximum);

        // Assert
        Assert.True(size > 0);
    }

    [Theory]
    [InlineData("Storage", "Azure Data Lake Storage Gen2 Hierarchical Namespace", "Hot LRS", "1 GB/Month", "eastus", "Hot LRS Data Stored", 0.0208)]
    public async Task EstimatedResourceRetailCost(string serviceName, string productName, string skuName, string unitOfMeasure, string region, string meterName, double cost) {
        // Arrange

        // Act
        var estimatedCost = await GetRetailCost(serviceName, productName, skuName, unitOfMeasure, region, meterName);

        // Assert
        Assert.True(estimatedCost <= cost);
    }

    [Theory]
    [InlineData("flowsession", 100000, "eastus", 0.3)]
    [InlineData("flowsession", 1000000, "eastus", 3)]
    [InlineData("flowsession", 10000000, "eastus", 30)]
    public async Task EstimatedFlowSessionRetailStorageCostAddedPerMonthLRS(string table, int resordsPerDay, string region, double cost)
    {
        // Arrange

        // Act
        var size = await GetRecordSize(table, "csv", CostType.Maximum);
       
        double totalGB = (size / BYTE_TO_GIGABYTE) * resordsPerDay;
      
        var estimatedCost = await GetRetailCost("Storage", "Azure Data Lake Storage Gen2 Hierarchical Namespace", "Hot LRS", "1 GB/Month", region, "Hot LRS Data Stored") * totalGB;
        _output.WriteLine($"{resordsPerDay} = {totalGB}GB = ${estimatedCost}");

        // Assert
        Assert.True(estimatedCost < cost);
    }

    [Theory]
    [InlineData("flowsession", 100000, "eastus", 25)]
    [InlineData("flowsession", 300000, "eastus", 75)]
    [InlineData("flowsession", 1000000, "eastus", 225)]
    public async Task EstimatedRetailStorageCostEndOfYear1LRS(string table, int recordsperday, string region, double cost)
    {
        // Arrange

        // Act
        var size = await GetRecordSize(table, "csv", CostType.Maximum);
        double byteToGigaByte = (1024 * 1024 * 1024); // To KB -> MB -> GB
        double totalGBPerMonth = (size / byteToGigaByte) * recordsperday;

        var estimatedCost = await GetRetailCost("Storage", "Azure Data Lake Storage Gen2 Hierarchical Namespace", "Hot LRS", "1 GB/Month", region, "Hot LRS Data Stored");

        double total = 0;
        double? cummulativeCost = 0;
        for ( var month = 1; month <= 12; month++ )
        {
            total += totalGBPerMonth;
            cummulativeCost += total * estimatedCost;
        }

        _output.WriteLine($"{recordsperday} = In Month 12 = ${cummulativeCost} for {total} GB");

        // Assert
        Assert.True(cummulativeCost < cost);
    }

    [Theory]
    [InlineData(0.5, "eastus", 0)]
    [InlineData(1, "eastus", 0)]
    [InlineData(1.5, "eastus", 2.5)]
    [InlineData(2, "eastus", 5)]
    public async Task GetRetailAzureSynapseSQLCost(double teraBytes, string region, double expected)
    {
        // Arrange
        var initialCost = await GetRetailCost("Azure Synapse Analytics", "Azure Synapse Analytics Serverless SQL Pool", "Standard", "1 TB", region, "Standard Data Processed", greaterOrEqualMin: true);

        Assert.Equal(0, initialCost);
        if ( teraBytes > 1 )
        {
            var nextCost = await GetRetailCost("Azure Synapse Analytics", "Azure Synapse Analytics Serverless SQL Pool", "Standard", "1 TB", region, "Standard Data Processed", 1.0, greaterOrEqualMin: true);

            var estimatedCost = (teraBytes - 1) * nextCost;
            Assert.True(estimatedCost <= expected);
        }
    }

    [Theory]
    [InlineData("eastus", CostType.Minimum, 100000, 0)]
    [InlineData("eastus", CostType.Average, 100000, 0)]
    [InlineData("eastus", CostType.Maximum, 100000, 0)]
    [InlineData("eastus", CostType.Maximum, 1000000, 0)]
    [InlineData("eastus", CostType.Maximum, 10000000, 2)]
    public async Task GetRetailFlowSessionAzureSynapseSQLCost(string region, CostType costType, int count, double expected)
    {
        // Arrange
        double estimatedSizeGB = (await GetRecordSize("flowsession", "csv", costType) * (double)count) / (BYTE_TO_GIGABYTE);
        double estimatedSizeTB = (estimatedSizeGB / 1024);
        var initialCost = await GetRetailCost("Azure Synapse Analytics", "Azure Synapse Analytics Serverless SQL Pool", "Standard", "1 TB", region, "Standard Data Processed", greaterOrEqualMin: true);

        _output.WriteLine($"{count} = {estimatedSizeTB} TB");

        Assert.Equal(0, initialCost);
        if (estimatedSizeTB > 1)
        {
            var nextCost = await GetRetailCost("Azure Synapse Analytics", "Azure Synapse Analytics Serverless SQL Pool", "Standard", "1 TB", region, "Standard Data Processed", 1.0, greaterOrEqualMin: true);

            var estimatedCost = (estimatedSizeTB - 1) * nextCost;

            Assert.True(estimatedCost <= expected);
        }
    }

    private async Task<double?> GetRetailCost(string serviceName, string productName, string skuName, string unitOfMeasure, string region, string meterName, double minUnits = 0.0, bool greaterOrEqualMin = false)
    {
        // Arrange
        var url = $"https://prices.azure.com/api/retail/prices?api-version=2023-01-01-preview&$filter=contains(serviceName,'{serviceName}') and skuName eq '{skuName}' and productName eq '{productName}' and armRegionName eq '{region}' and unitOfMeasure eq '{unitOfMeasure}' and tierMinimumUnits eq {minUnits} and meterName eq '{meterName}'";


        // Act
        string pricesJson = HttpCache.ContainsKey(url) ? HttpCache[url] : "";
        if (string.IsNullOrEmpty(pricesJson))
        {
            // Cache the results to avoid 429 (Too Many Requests) error
            pricesJson = await new HttpClient().GetStringAsync(url);
            HttpCache.Add(url, pricesJson);
        }

        var prices = JObject.Parse(pricesJson);

        var items = prices?.Property("Items")?.Value as JArray;
        var item = items?.Where(p => p is JObject && (
            (!greaterOrEqualMin && ((JObject)p)?.Property("retailPrice")?.Value.Value<double>() > 0)
            ||
            (greaterOrEqualMin && ((JObject)p)?.Property("retailPrice")?.Value.Value<double>() >= minUnits)
        )).FirstOrDefault() as JObject;

        return item?.Property("retailPrice")?.Value.Value<double>();
    }

    private async Task<int> GetRecordSize(string table, string format, CostType costType)
    {
        var html = await new HttpClient().GetStringAsync($"https://learn.microsoft.com/en-us/power-apps/developer/data-platform/reference/entities/{table}");

        HtmlDocument doc = new HtmlDocument();
        doc.LoadHtml(html);

        Assert.NotNull(doc.DocumentNode);

        List<string> columns = new List<string>();

        int size = GetEntityAttributes(doc.DocumentNode, "writable-columnsattributes", format, costType, columns);
        size += GetEntityAttributes(doc.DocumentNode, "read-only-columnsattributes", format, costType, columns);
        // Assume end in new line
        if ( format == "csv" )
        {
            size += GetSize("\r\n");

        }
        
        return size;
    }

    private int GetEntityAttributes(HtmlNode node, string section, string format, CostType costType, List<String> columnNames)
    {
        int size = 0;

        var current = node.SelectNodes($"//h2[@id='{section}']").FirstOrDefault();
        while (current != null)
        {
            current = current.NextSibling;
            if (current?.Name == "ul")
            {
                break;
            }
        }

        // Should be at UL list after the heading
        var items = current?.SelectNodes(".//li/a");

        switch (format)
        {
            case "csv":
                if (items != null)
                {
                    // Add byte count for each column
                    size += GetSize(",") * items.Count;
                    foreach (var item in items)
                    {
                        var name = item.GetAttributeValue<string>("href", "");
                        if (!columnNames.Contains(name))
                        {
                            columnNames.Add(name);
                            size += GetColumnSize(node, name, format, costType);
                        }
                    }
                }

                break;
            default:
                throw new DataException("Not supported data type format " + format);
        }

        return size;

    }

    private int GetSize(string text)
    {
        return UTF8Encoding.UTF8.GetBytes(text, 0, text.Length).Length;
    }

    private int GetColumnSize(HtmlNode document, string name, string format, CostType costType)
    {
        var match = document.SelectSingleNode($"//*[@id='{name.Replace("#","")}']");
        if ( match != null )
        {
            HtmlNode table = null;
            var current = match;
            while ( current != null )
            {
                current = current.NextSibling;
                if (current != null && current.Name == "table") {
                    table = current;
                    break;
                }
            }
            if ( table != null )
            {
                var type = GetTableValue(table, "Type");
                // https://learn.microsoft.com/en-us/power-apps/maker/data-platform/types-of-fields
                switch (type.ToLower())
                {
                    case "Boolean":
                        return GetSize("false");
                    case "string":
                    case "memo":
                        switch (costType) {
                            case CostType.Minimum:
                                // Assume empty value is not quoted
                                return 0;
                            case CostType.Average:
                                return (int)(int.Parse(GetTableValue(table, "MaxLength")) * 0.1);
                            case CostType.Maximum:
                                return int.Parse(GetTableValue(table, "MaxLength"));
                        }
                        break;
                    case "text":
                        return GetSize("X") * 4000;
                    case "picklist":
                        return GetSize("1");
                        return GetSize("X") * 1048576;
                    case "integer":
                        switch (costType)
                        {
                            case CostType.Minimum:
                                return GetSize("0");
                            case CostType.Average:
                                return GetSize("32768");
                            case CostType.Maximum:
                                return GetSize(int.MaxValue.ToString());
                        }
                        break;
                    case "bigint":
                        switch (costType)
                        {
                            case CostType.Minimum:
                                return GetSize("0");
                            default:
                                return GetSize("9223372036854775807");
                        }
                    case "uniqueidentifier":
                    case "lookup":
                    case "owner":
                        switch (costType)
                        {
                            case CostType.Minimum:
                                return GetSize("0");
                            default:
                                return GetSize(Guid.NewGuid().ToString());
                        }
                    case "entityname":
                        switch (costType)
                        {
                            case CostType.Minimum:
                                return GetSize("0");
                            case CostType.Average:
                                return GetSize("0") * 30;
                            default:
                                // Assume max length of table name is 128 characters
                                //https://learn.microsoft.com/en-us/power-apps/developer/data-platform/reference/entities/entity#BKMK_BaseTableName
                                return GetSize("\"\"") + GetSize("1") * 128;
                        }
                    case "state":
                        // Asume this is an int
                        switch (costType)
                        {
                            case CostType.Minimum:
                                return GetSize("1");
                            default:
                                return GetSize(int.MaxValue.ToString());
                        }
                    case "statuscode":
                        switch (costType)
                        {
                            case CostType.Minimum:
                                return GetSize("0");
                            case CostType.Average:
                                return GetSize("0") * 2;
                            default:
                                return GetSize(int.MaxValue.ToString());
                        }
                    case "datetime":
                        switch (costType)
                        {
                            case CostType.Minimum:
                                // Assume may not have a value
                                return 0;
                            default:
                                return GetSize($"\"{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt")}\"");
                        }
                    case "file":
                        // Assume will have placeholder for file name
                        return GetSize("\"untitled.txt\"");
                }
            }

        } else {
            throw new DataException($"Unable to find column {name}");
        }

        return 0;
    }

    private string GetTableValue(HtmlNode table, string name)
    {
        var row = table.SelectSingleNode($".//tr/td[text() = '{name}']");
        if ( row != null  )
        {
            var cells = row.ParentNode.SelectNodes(".//td");
            return cells?.Skip(1)?.FirstOrDefault()?.InnerText;
        }
        return String.Empty;
    }
}