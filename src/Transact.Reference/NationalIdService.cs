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

namespace OpenTemenos.Transacts.Reference.NationalIds
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface INationalIdService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the BIC code of the requested Bank's legal entity identifier</summary>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <returns>BICFromLEIResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BICFromLEIResponse> GetBICFromLEIAsync(string leiId, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the BIC or BICs for a given national ID with its country code or scheme.</summary>
        /// <param name="countryId">ISO country code of the financial institution.</param>
        /// <param name="scheme">Represents the scheme (a synonym for the National ID type) under which the National ID is defined</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <returns>BICsFromNationalIdResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BICsFromNationalIdResponse> GetBICsFromNationalIdAsync(string nationalIdRef, string? countryId = null, string? scheme = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the details of the given national ID</summary>
        /// <param name="countryId">ISO country code of the financial institution.</param>
        /// <param name="scheme">Represents the scheme (a synonym for the National ID type) under which the National ID is defined</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <returns>NationalIdDetailsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<NationalIdDetailsResponse> GetNationalIdDetailsAsync(string nationalIdRef, string? countryId = null, string? scheme = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves national IDs for a BIC</summary>
        /// <param name="bicId">Bank Identifier Code (BIC) of the Beneficiary bank.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <returns>NationalIdsFromBicResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<NationalIdsFromBicResponse> GetNationalIdsFromBicAsync(string bicId, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the status on the validity of the given national ID</summary>
        /// <param name="countryId">ISO country code of the financial institution.</param>
        /// <param name="scheme">Represents the scheme (a synonym for the National ID type) under which the National ID is defined</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <returns>NationalIdResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<NationalIdResponse> ValidateNationalIdAsync(string nationalIdRef, string? countryId = null, string? scheme = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves GPI participant information</summary>
        /// <param name="participantId">Process Workflow Participant ID</param>
        /// <param name="countryId">ISO country code of the financial institution.</param>
        /// <param name="currencyCode">ISO Currency code, accepted in field 32A of incoming gpi MT 103 payment by the participant ID or by the gpi intermediary through which the participant can be reached for this currency</param>
        /// <param name="requestDate">Date on which the client's request to be classified as professional has been received.</param>
        /// <param name="channelType">Indicates the type of the Reachable Through channel</param>
        /// <param name="reachableThrough">Channel through which the participant is reachable for Global Payment Initiative (GPI) payment instructions for one of its GPI currencies</param>
        /// <param name="actAsIntermediary">Flag specifying whether the participant acts as the Global Payment Initiative (GPI) Intermediary Agent for GPI payments in a given currency and over a given REACHABLE THROUGH channel. Y indicates that the participant will forward incoming MT 103s payments coming from a GPI participant through this channel and in this currency to an upcoming GPI participant, per the GPI business rules.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">The identifier of the underlying Entity/Company/Branch.</param>
        /// <returns>ParticipantDetailsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<ParticipantDetailsResponse> GetParticipantDetailsAsync(string participantId, string countryId, string currencyCode, string? requestDate = null, string? channelType = null, string? reachableThrough = null, string? actAsIntermediary = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class QueryHeader 
    {
        [Newtonsoft.Json.JsonProperty("audit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Audit? Audit { get; set; }= default!;
    
        /// <summary>The total number of records per page</summary>
        [Newtonsoft.Json.JsonProperty("page_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Page_size { get; set; }= default!;
    
        /// <summary>The record from which the response should be displayed</summary>
        [Newtonsoft.Json.JsonProperty("page_start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Page_start { get; set; }= default!;
    
        /// <summary>The total number of records present</summary>
        [Newtonsoft.Json.JsonProperty("total_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Total_size { get; set; }= default!;
    
        /// <summary>Unique id expected to get as part of response from t24 on every enquiry request</summary>
        [Newtonsoft.Json.JsonProperty("page_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Page_token { get; set; }= default!;
    
    
    }
    
    /// <summary>BICFromLEIResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BICFromLEIResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public QueryHeader? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BICFromLEIResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BICFromLEIResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
    {
    
    }
    
    /// <summary>BusinessQueryErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BusinessQueryErrorResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ErrorHeader? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BusinessQueryErrorResponseBody? Error { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BusinessQueryErrorResponseBody 
    {
        /// <summary>The identifier of the error message</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Code { get; set; }= default!;
    
        /// <summary>The actual t24 error message for bad requests</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Message { get; set; }= default!;
    
        /// <summary>The identifier of error type: Business</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Type { get; set; }= default!;
    
    
    }
    
    /// <summary>SystemQueryErrorResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SystemQueryErrorResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ErrorHeader? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SystemQueryErrorResponseBody? Error { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SystemQueryErrorResponseBody 
    {
        /// <summary>The identifier of the error message</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Code { get; set; }= default!;
    
        /// <summary>The actual t24 error message caused by server</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Message { get; set; }= default!;
    
        /// <summary>The identifier of error type: System</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Type { get; set; }= default!;
    
    
    }
    
    /// <summary>BICsFromNationalIdResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BICsFromNationalIdResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public QueryHeader? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BICsFromNationalIdResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BICsFromNationalIdResponseBody : System.Collections.ObjectModel.Collection<Anonymous2>
    {
    
    }
    
    /// <summary>NationalIdDetailsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class NationalIdDetailsResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public QueryHeader? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public NationalIdDetailsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class NationalIdDetailsResponseBody : System.Collections.ObjectModel.Collection<Anonymous3>
    {
    
    }
    
    /// <summary>NationalIdsFromBicResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class NationalIdsFromBicResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public QueryHeader? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public NationalIdsFromBicResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class NationalIdsFromBicResponseBody : System.Collections.ObjectModel.Collection<Anonymous4>
    {
    
    }
    
    /// <summary>NationalIdResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class NationalIdResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public QueryHeader? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public NationalIdResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class NationalIdResponseBody : System.Collections.ObjectModel.Collection<Anonymous5>
    {
    
    }
    
    /// <summary>ParticipantDetailsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ParticipantDetailsResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public QueryHeader? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ParticipantDetailsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ParticipantDetailsResponseBody : System.Collections.ObjectModel.Collection<Anonymous6>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Anonymous 
    {
        /// <summary>Bank Identifier Code (BIC) of the Beneficiary bank.</summary>
        [Newtonsoft.Json.JsonProperty("bicId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BicId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Audit2 
    {
        /// <summary>Time taken to response by T24</summary>
        [Newtonsoft.Json.JsonProperty("T24_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? T24_time { get; set; }= default!;
    
        /// <summary>The CURR.NO. of the record</summary>
        [Newtonsoft.Json.JsonProperty("versionNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VersionNumber { get; set; }= default!;
    
        /// <summary>Time taken to parse the request by IRIS</summary>
        [Newtonsoft.Json.JsonProperty("requestParse_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RequestParse_time { get; set; }= default!;
    
        /// <summary>Time taken to parse the response by IRIS</summary>
        [Newtonsoft.Json.JsonProperty("responseParse_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ResponseParse_time { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Anonymous2 
    {
        /// <summary>The BIC code of the Beneficiary bank</summary>
        [Newtonsoft.Json.JsonProperty("bics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Bics>? Bics { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Anonymous3 
    {
        [Newtonsoft.Json.JsonProperty("addressInformation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AddressInformation>? AddressInformation { get; set; }= default!;
    
        /// <summary>National identifier of the institution/branch. This field contains the National bank code for the financial institution (for example, BSC codes for UK banks)</summary>
        [Newtonsoft.Json.JsonProperty("nationalId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NationalId { get; set; }= default!;
    
        /// <summary>Represents the scheme (a synonym for the National ID type) under which the National ID is defined</summary>
        [Newtonsoft.Json.JsonProperty("scheme", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Scheme { get; set; }= default!;
    
        /// <summary>Identifies the Financial Institution of BIC</summary>
        [Newtonsoft.Json.JsonProperty("institutionName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstitutionName { get; set; }= default!;
    
        /// <summary>The branch information relevant to this BIC code.</summary>
        [Newtonsoft.Json.JsonProperty("branch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Branch { get; set; }= default!;
    
        /// <summary>Indicates the status of the entity in the office hierarchy e.g. Head Office, Main Payments Office</summary>
        [Newtonsoft.Json.JsonProperty("officeType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OfficeType { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Anonymous4 
    {
        [Newtonsoft.Json.JsonProperty("nationalIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<NationalIds>? NationalIds { get; set; }= default!;
    
        /// <summary>Bank Identifier Code (BIC) of the Beneficiary bank.</summary>
        [Newtonsoft.Json.JsonProperty("bicId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? BicId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Anonymous5 
    {
        /// <summary>National identifier of the institution/branch. This field contains the National bank code for the financial institution (for example, BSC codes for UK banks)</summary>
        [Newtonsoft.Json.JsonProperty("nationalId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NationalId { get; set; }= default!;
    
        /// <summary>Represents the scheme (a synonym for the National ID type) under which the National ID is defined</summary>
        [Newtonsoft.Json.JsonProperty("scheme", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Scheme { get; set; }= default!;
    
        /// <summary>Indicates whether the National Id is valid</summary>
        [Newtonsoft.Json.JsonProperty("isNationalIdValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string? IsNationalIdValid { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Anonymous6 
    {
        /// <summary>Process Workflow Participant ID</summary>
        [Newtonsoft.Json.JsonProperty("participantId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParticipantId { get; set; }= default!;
    
        /// <summary>Specifies the type of the identifier used for the participant ID such as the BIC or NATIONAL.ID of a non-financial Payments Market Infrastructures (PMI)</summary>
        [Newtonsoft.Json.JsonProperty("idType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IdType { get; set; }= default!;
    
        /// <summary>Specifies the institution name of the participant</summary>
        [Newtonsoft.Json.JsonProperty("participantName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParticipantName { get; set; }= default!;
    
        /// <summary>ISO country code of the financial institution. </summary>
        [Newtonsoft.Json.JsonProperty("countryId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CountryId { get; set; }= default!;
    
        /// <summary>ISO Currency code, accepted in field 32A of incoming gpi MT 103 payment by the participant ID or by the gpi intermediary through which the participant can be reached for this currency</summary>
        [Newtonsoft.Json.JsonProperty("currencyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrencyCode { get; set; }= default!;
    
        /// <summary>The Cut off time when all executions for the day are consolidated to create a trade</summary>
        [Newtonsoft.Json.JsonProperty("cutOffTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CutOffTime { get; set; }= default!;
    
        /// <summary>Indicates the last day for Global Payment Initiative (GPI) payments in a given currency</summary>
        [Newtonsoft.Json.JsonProperty("cutOffDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CutOffDay { get; set; }= default!;
    
        /// <summary>Specifies the time zone of the participant</summary>
        [Newtonsoft.Json.JsonProperty("localTimezone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LocalTimezone { get; set; }= default!;
    
        /// <summary>Flag specifying whether the participant acts as the Global Payment Initiative (GPI) Intermediary Agent for GPI payments in a given currency and over a given REACHABLE THROUGH channel. Y indicates that the participant will forward incoming MT 103s payments coming from a GPI participant through this channel and in this currency to an upcoming GPI participant, per the GPI business rules.</summary>
        [Newtonsoft.Json.JsonProperty("actAsIntermediary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActAsIntermediary { get; set; }= default!;
    
        /// <summary>Channel through which the participant is reachable for Global Payment Initiative (GPI) payment instructions for one of its GPI currencies</summary>
        [Newtonsoft.Json.JsonProperty("reachableThrough", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReachableThrough { get; set; }= default!;
    
        /// <summary>Indicates the type of the Reachable Through channel</summary>
        [Newtonsoft.Json.JsonProperty("channelType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ChannelType { get; set; }= default!;
    
        /// <summary>Contains the date on which the transaction or payment gets initiated.</summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StartDate { get; set; }= default!;
    
        /// <summary>Indicates the date on which the Payment Stop is placed</summary>
        [Newtonsoft.Json.JsonProperty("stopDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StopDate { get; set; }= default!;
    
        /// <summary>Record key of the Standing Settlement Instruction (SSI) in SWIFTRef's SSI Plus directory for this participant and currency. An SSI can list which correspondent bank and which account number at that correspondent bank to use to cover payments in a given currency directed to the participant or directed at the intermediary.</summary>
        [Newtonsoft.Json.JsonProperty("ssiRecordKey", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsiRecordKey { get; set; }= default!;
    
        /// <summary>Bank Identifier Code (BIC) which must take the action of forwarding the payment or updating the tracker on behalf of the participant ID.</summary>
        [Newtonsoft.Json.JsonProperty("delegatedTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DelegatedTo { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Bics 
    {
        /// <summary>Bank Identifier Code (BIC) of the Beneficiary bank.</summary>
        [Newtonsoft.Json.JsonProperty("bicId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string>? BicId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AddressInformation 
    {
        /// <summary>First line of the address</summary>
        [Newtonsoft.Json.JsonProperty("addressLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddressLine1 { get; set; }= default!;
    
        /// <summary>Second line of the address</summary>
        [Newtonsoft.Json.JsonProperty("addressLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddressLine2 { get; set; }= default!;
    
        /// <summary>Third line of the address</summary>
        [Newtonsoft.Json.JsonProperty("addressLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddressLine3 { get; set; }= default!;
    
        /// <summary>Fourth line of the address</summary>
        [Newtonsoft.Json.JsonProperty("addressLine4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddressLine4 { get; set; }= default!;
    
        /// <summary>Indicates first line of branch location of the financial institution</summary>
        [Newtonsoft.Json.JsonProperty("bicLocation1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BicLocation1 { get; set; }= default!;
    
        /// <summary>Indicates second line of branch location of the financial institution</summary>
        [Newtonsoft.Json.JsonProperty("bicLocation2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BicLocation2 { get; set; }= default!;
    
        /// <summary>The town and/or city component of the base address of a customer</summary>
        [Newtonsoft.Json.JsonProperty("addressCity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddressCity { get; set; }= default!;
    
        /// <summary>Identifies the address postal code for the customer.</summary>
        [Newtonsoft.Json.JsonProperty("postCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PostCode { get; set; }= default!;
    
        /// <summary>This is the country name that the financial institution resides in.</summary>
        [Newtonsoft.Json.JsonProperty("countryName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CountryName { get; set; }= default!;
    
        /// <summary>ISO country code of the financial institution. </summary>
        [Newtonsoft.Json.JsonProperty("countryId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CountryId { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class NationalIds 
    {
        /// <summary>National identifier of the institution/branch. This field contains the National bank code for the financial institution (for example, BSC codes for UK banks)</summary>
        [Newtonsoft.Json.JsonProperty("nationalId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NationalId { get; set; }= default!;
    
        /// <summary>Represents the scheme (a synonym for the National ID type) under which the National ID is defined</summary>
        [Newtonsoft.Json.JsonProperty("scheme", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Scheme { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016