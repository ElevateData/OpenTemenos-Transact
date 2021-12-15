//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#nullable enable

using OpenTemenos.Shared.Models;

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"

namespace OpenTemenos.Transacts.Microservice.Meterings
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IMeteringService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves metering configuration details for a specified application</summary>
        /// <param name="applicationId">Indicates unique identifier of an application</param>
        /// <param name="resourceId">Indicates optional Unique identifier for the resource usage measured in order to filter records</param>
        /// <returns>Searches and retrieves the metric data logged for the given application</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<MeteringAppConfiguration>> GetAppMetricConfigAsync(string applicationId, string? resourceId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates configuration details for  metering an application</summary>
        /// <param name="applicationId">Indicates Unique identifier of the application</param>
        /// <param name="body">Request body for the metering app configuration details consisting of resourceId, metricType, statisticsType and additional properties</param>
        /// <returns>Displays the response object which contains configId, applicationId, metricResourceId and status</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<MeteringAppConfigurationResponse> CreateAppMeteringConfigAsync(string applicationId, MeteringAppConfiguration? body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the metering configuration details of metering application for a specified configuration id.</summary>
        /// <param name="configurationId">Indicates unique identifier of a configuration of a metered resource in an application</param>
        /// <returns>Array of metric data logged which consists of configId, resourceId, metricType, statisticsType and addtional properties</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<MeteringAppConfiguration> GetApplicationMetricsConfigAsync(string configurationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates an application Metering Configuration for a specified configuration id</summary>
        /// <param name="configurationId">Indicates unique identifier of a configuration of a metered resource in an application</param>
        /// <param name="body">Request body of metering update configuration consisting of applicationId, resourceId, metricType, statisticsType and addtional properties.</param>
        /// <returns>Response object for Metering App Configuration consisting of configId, applicationId, metricResourceId and the status</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<MeteringAppConfigurationResponse> UpdateAppMeteringConfigAsync(string configurationId, MeteringUpdateConfiguration? body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Deletes an application metric configuration for a specified configuration id</summary>
        /// <param name="configurationId">Indicates unique identifier of a configuration for a metered resource in an application</param>
        /// <returns>Response object for Metering Delete Configuration consisting of configurationId and the status</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<MeteringDeleteConfigurationResponse> DeleteAppMeteringConfigAsync(string configurationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves  metrics entries logged for an application</summary>
        /// <param name="applicationId">Indicates the unique identifier of an application</param>
        /// <param name="fromDate">Indicates the date from which metric data is requested</param>
        /// <param name="toDate">Indicates the date upto which metric data is requested</param>
        /// <param name="resourceId">Indicates Unique identifier for the resource usage measured</param>
        /// <param name="metricId">Indicates the identifier to identify the catagory of Metrics data</param>
        /// <returns>Array of metric data logged consisting of resouceId, metricId, meteredDate, usage count and some addtional data</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<MetricDataLog>> GetMetricLogDataAsync(string applicationId, System.DateTimeOffset fromDate, System.DateTimeOffset toDate, string? resourceId = null, string? metricId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Add metered meterics data in the Metering service</summary>
        /// <param name="requestId">Indicates the identifier of request</param>
        /// <param name="applicationId">Indicates the Unique identifier of an application</param>
        /// <param name="body">Request body of Metric Data Log consisting of resourceId, metricId, meteredDate, usage count and addittional data</param>
        /// <returns>Response object of Metric Data Response consisting of applicationId, metricId, resourceId, usage count and status</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<AddMetricDataResponse> AddMetricDataAsync(System.Guid requestId, string applicationId, System.Collections.Generic.IEnumerable<MetricDataLog>? body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves statistics report on business values and api usage metrics data.</summary>
        /// <param name="applicationId">Indicates Unique identifier of the application</param>
        /// <param name="fromDate">Indicates the date from which metric data is requested</param>
        /// <param name="toDate">Indicates the date upto which metric data is requested</param>
        /// <returns>Array of metric statistics data for the given application consisting of applicationId, resourceId, metricId, meteredDate and usage count total</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<UsageStatisticsData>> GetUsageStatisticsAsync(string applicationId, System.DateTimeOffset fromDate, System.DateTimeOffset toDate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves tamper evidence report for a specific applicationid and metric id.</summary>
        /// <param name="appId">Indicates Unique identifier of the application</param>
        /// <param name="resourceId">Indicates Unique identifier for the resource usage measured.</param>
        /// <param name="metricId">Indicates identifier to get the catagory of Metrics data</param>
        /// <returns>Response object of Evidence consisting of data logs and request logs along with algorithm used and the corresponsing hash.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<VerifiableDataLog>> GetEvidenceAsync(string appId, string resourceId, string metricId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AddMetricDataResponse 
    {
        /// <summary>Identifier of an application</summary>
        [Newtonsoft.Json.JsonProperty("applicationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }= default!;
    
        /// <summary>Indicates identifier of the metric</summary>
        [Newtonsoft.Json.JsonProperty("metricId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MetricId { get; set; }= default!;
    
        /// <summary>Indicates identifier of the resouce</summary>
        [Newtonsoft.Json.JsonProperty("resourceId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResourceId { get; set; }= default!;
    
        /// <summary>Indicates the usage count of the metrics</summary>
        [Newtonsoft.Json.JsonProperty("usedCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double UsedCount { get; set; }= default!;
    
        /// <summary>Indicates success or failure status</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MeteringDeleteConfigurationResponse 
    {
        /// <summary>Identifier of a metric configuration</summary>
        [Newtonsoft.Json.JsonProperty("configId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConfigId { get; set; }= default!;
    
        /// <summary>Indicates success or failure status</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MeteringAppConfigurationResponse 
    {
        /// <summary>Identifier of a metric configuration</summary>
        [Newtonsoft.Json.JsonProperty("configId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConfigId { get; set; }= default!;
    
        /// <summary>Indicates the identifier of an application</summary>
        [Newtonsoft.Json.JsonProperty("applicationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }= default!;
    
        /// <summary>Indicates the identifier of a metric resource</summary>
        [Newtonsoft.Json.JsonProperty("metricResourceId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MetricResourceId { get; set; }= default!;
    
        /// <summary>Indicates success or failure status</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MeteringAppConfiguration 
    {
        /// <summary>Identifier of a metric configuration</summary>
        [Newtonsoft.Json.JsonProperty("configId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ConfigId { get; set; }= default!;
    
        /// <summary>Indicates the identifier of a resource</summary>
        [Newtonsoft.Json.JsonProperty("resourceId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResourceId { get; set; }= default!;
    
        /// <summary>Indicates the type of the metric captured.</summary>
        [Newtonsoft.Json.JsonProperty("metricType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MeteringAppConfigurationMetricType MetricType { get; set; }= default!;
    
        /// <summary>Indicates the usage count calculation method C-cumulative, D-Daily</summary>
        [Newtonsoft.Json.JsonProperty("statisticsType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MeteringAppConfigurationStatisticsType StatisticsType { get; set; }= default!;
    
        /// <summary>Indicates the description of the metric configuration</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }= default!;
    
        /// <summary>Indicates the place holder to capture additional data in the key value format</summary>
        [Newtonsoft.Json.JsonProperty("additionaldata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Additionaldata { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MeteringUpdateConfiguration 
    {
        /// <summary>Indicates the identifier of the application</summary>
        [Newtonsoft.Json.JsonProperty("applicationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }= default!;
    
        /// <summary>Indicates the identifier of the resource</summary>
        [Newtonsoft.Json.JsonProperty("resourceId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResourceId { get; set; }= default!;
    
        /// <summary>Indicates the type of metrics captured.</summary>
        [Newtonsoft.Json.JsonProperty("metricType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MeteringUpdateConfigurationMetricType MetricType { get; set; }= default!;
    
        /// <summary>Indicates the usage count calculation method C-cumulative, D-Daily</summary>
        [Newtonsoft.Json.JsonProperty("statisticsType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MeteringUpdateConfigurationStatisticsType StatisticsType { get; set; }= default!;
    
        /// <summary>Indicates the description of the metric configuration</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }= default!;
    
        /// <summary>Indicates the place holder to capture additional data in the key value format</summary>
        [Newtonsoft.Json.JsonProperty("additionaldata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Additionaldata { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>List of Metering App Configuration</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MeteringAppConfigurationList : System.Collections.ObjectModel.Collection<MeteringAppConfiguration>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MetricDataLog 
    {
        /// <summary>Indicates the  identifier of the resource and domain id of the API in case of IRIS-API</summary>
        [Newtonsoft.Json.JsonProperty("resourceId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResourceId { get; set; }= default!;
    
        /// <summary>Indicates the identifier of the api metrics measured and route Id in case of IRIS API</summary>
        [Newtonsoft.Json.JsonProperty("metricId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MetricId { get; set; }= default!;
    
        /// <summary>Indicates the metered date in UTC timezone.</summary>
        [Newtonsoft.Json.JsonProperty("meteredDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset MeteredDate { get; set; }= default!;
    
        /// <summary>Indicates the usage count of the metric</summary>
        [Newtonsoft.Json.JsonProperty("usedCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double UsedCount { get; set; }= default!;
    
        /// <summary>Indicates if the measured usage count is incremental or total count for the specified metric.</summary>
        [Newtonsoft.Json.JsonProperty("isIncremental", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsIncremental { get; set; }= default!;
    
        /// <summary>Indicates the place holder to capture additional data in the key value format</summary>
        [Newtonsoft.Json.JsonProperty("additionaldata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Additionaldata { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>List of Metric Data Log</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MetricDataLogList : System.Collections.ObjectModel.Collection<MetricDataLog>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class UsageStatisticsData 
    {
        /// <summary>Indicates the identifier of application</summary>
        [Newtonsoft.Json.JsonProperty("applicationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }= default!;
    
        /// <summary>Indicates the  identifier of the resource usage measured.</summary>
        [Newtonsoft.Json.JsonProperty("resourceId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResourceId { get; set; }= default!;
    
        /// <summary>Indicates the measured metrics identifier</summary>
        [Newtonsoft.Json.JsonProperty("metricId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MetricId { get; set; }= default!;
    
        /// <summary>Indicates the metered date</summary>
        [Newtonsoft.Json.JsonProperty("meteredDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset MeteredDate { get; set; }= default!;
    
        /// <summary>Indicates total usage count measured for the speficied metric</summary>
        [Newtonsoft.Json.JsonProperty("totalUsageCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TotalUsageCount { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>List of Usage Statistics Data</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class UsageStatisticsDataList : System.Collections.ObjectModel.Collection<UsageStatisticsData>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class HashChain 
    {
        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Direction { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("siblingHash", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SiblingHash { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("levelCorrection", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double LevelCorrection { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>Contains Metric Data Log, request log, merkle tree root and hashchain</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class VerifiableDataLog 
    {
        [Newtonsoft.Json.JsonProperty("datalog", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MetricDataLog Datalog { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("requestLog", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RequestLog { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("merkleTreeRoot", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MerkleTreeRoot { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("hashChain", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<HashChain> HashChain { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>List of Veriable Data Log</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Evidence : System.Collections.ObjectModel.Collection<VerifiableDataLog>
    {
    
    }
    
    /// <summary>Contains the error code along with the error message</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ErrorDetails 
    {
        [Newtonsoft.Json.JsonProperty("errorcode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Errorcode { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("errorstring", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Errorstring { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>List of Error Details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Errorschema : System.Collections.ObjectModel.Collection<ErrorDetails>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum MeteringAppConfigurationMetricType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"COUNT")]
        COUNT = 0,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum MeteringAppConfigurationStatisticsType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"C")]
        C = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"D")]
        D = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum MeteringUpdateConfigurationMetricType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"COUNT")]
        COUNT = 0,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum MeteringUpdateConfigurationStatisticsType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"C")]
        C = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"D")]
        D = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
    internal class DateFormatConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        public DateFormatConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016