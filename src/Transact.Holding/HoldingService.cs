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

namespace OpenTemenos.Transacts.Holding.Services
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IHoldingService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the list of product(Current/Saving/Loan/Deposit) details</summary>
        /// <param name="customerId">Identifier of the customer</param>
        /// <param name="holdingsType">Contains the types of customer holdings</param>
        /// <param name="holdingsId">Contains the identifier specific to the holding details of the customer</param>
        /// <param name="getPreferredHoldings">Flag to fetch the preferred holding details (JWT required)</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from Transact on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>HoldingsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<HoldingsResponse> GetHoldingsAsync(string? customerId = null, string? holdingsType = null, string? holdingsId = null, string? getPreferredHoldings = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, bool? disablePagination = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the list of customer accounts</summary>
        /// <param name="customerId">Identifier of the customer</param>
        /// <param name="holdingsType">Contains the types of customer holdings</param>
        /// <param name="holdingsId">Contains the identifier specific to the holding details of the customer</param>
        /// <param name="getPreferredHoldings">Flag to fetch the preferred holding details (JWT required)</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from Transact on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>CustomerHoldingsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<HoldingsResponse> GetCustomerHoldingsAsync(string customerId, string? holdingsType = null, string? holdingsId = null, string? getPreferredHoldings = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, bool? disablePagination = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class QueryHeader 
    {
        [Newtonsoft.Json.JsonProperty("audit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Audit? Audit { get; set; }= default!;
    
        /// <summary>Status of the API(success/failed)</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Status { get; set; }= default!;
    
        /// <summary>The total number of records per page</summary>
        [Newtonsoft.Json.JsonProperty("page_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Page_size { get; set; }= default!;
    
        /// <summary>The record from which the response should be displayed</summary>
        [Newtonsoft.Json.JsonProperty("page_start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Page_start { get; set; }= default!;
    
        /// <summary>The total number of records present</summary>
        [Newtonsoft.Json.JsonProperty("total_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Total_size { get; set; }= default!;
    
        /// <summary>Unique id expected to get as part of response from Transact on every enquiry request</summary>
        [Newtonsoft.Json.JsonProperty("page_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Page_token { get; set; }= default!;
    
    
    }
    
    /// <summary>HoldingsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class HoldingsResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public QueryHeader? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public HoldingsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class HoldingsResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
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
    
        /// <summary>The actual Transact error message for bad requests</summary>
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
    
        /// <summary>The actual Transact error message caused by server</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Message { get; set; }= default!;
    
        /// <summary>The identifier of error type: System</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Type { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Anonymous 
    {
        /// <summary>Contains the templates used for payment transactions</summary>
        [Newtonsoft.Json.JsonProperty("products", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Products>? Products { get; set; }= default!;
    
        /// <summary>The top level product line, which the product is ultimately attached to. May be a Temenos-defined product line such as ACCOUNTS, AGENT, BUNDLE, CONSENT, DEPOSITS, LENDING, REWARDS, etc. or one defined by the institution to manage external products.</summary>
        [Newtonsoft.Json.JsonProperty("productLineId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductLineId { get; set; }= default!;
    
        /// <summary>Contains the final balances of all accounts after all transactions have taken place</summary>
        [Newtonsoft.Json.JsonProperty("totalAccountBalances", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalAccountBalances { get; set; }= default!;
    
        /// <summary>Contains the final balances of all deposit accounts after all transactions have taken place</summary>
        [Newtonsoft.Json.JsonProperty("totalDepositBalances", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalDepositBalances { get; set; }= default!;
    
        /// <summary>Contains the final balances of all loans after all payments have taken place</summary>
        [Newtonsoft.Json.JsonProperty("totalLoanBalances", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalLoanBalances { get; set; }= default!;
    
        /// <summary>Contains the final balances of all the external accounts</summary>
        [Newtonsoft.Json.JsonProperty("totalExtAccountBalances", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TotalExtAccountBalances { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Audit2 
    {
        /// <summary>Time taken to response by Transact</summary>
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
    public partial class Products 
    {
        /// <summary>Description of the product line, e.g. Client Consent for product line CONSENT.</summary>
        [Newtonsoft.Json.JsonProperty("productLineName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductLineName { get; set; }= default!;
    
        /// <summary>Indicates an unique identifier of an account</summary>
        [Newtonsoft.Json.JsonProperty("arrangementId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ArrangementId { get; set; }= default!;
    
        /// <summary>The group, as defined by the institution, that the product belongs to.</summary>
        [Newtonsoft.Json.JsonProperty("productGroupId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductGroupId { get; set; }= default!;
    
        /// <summary>Description of the product group</summary>
        [Newtonsoft.Json.JsonProperty("productGroupName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductGroupName { get; set; }= default!;
    
        /// <summary>Contains the unique identifier of the product, e.g. the product id of the arrangement account.</summary>
        [Newtonsoft.Json.JsonProperty("productId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductId { get; set; }= default!;
    
        /// <summary>Indicates the description of the Product</summary>
        [Newtonsoft.Json.JsonProperty("productDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProductDescription { get; set; }= default!;
    
        /// <summary>Identifier of the account. Often referred to as the account number, yet for consistency this is always referred to as accountId. Accepts both IBAN &amp; BBAN</summary>
        [Newtonsoft.Json.JsonProperty("accountId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AccountId { get; set; }= default!;
    
        /// <summary>Short title given to the name of the arrangement</summary>
        [Newtonsoft.Json.JsonProperty("shortTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ShortTitle { get; set; }= default!;
    
        /// <summary>Unique identifier associated with the product name of the account or contract. For example: For customer/counterparty accounts, the identifier would be in the range 1000 to 9999. For ledger accounts, in the range 10000 to 19999.</summary>
        [Newtonsoft.Json.JsonProperty("categoryId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CategoryId { get; set; }= default!;
    
        /// <summary>Specifies the company code which will be the master company for this institution. E.g. GB0010001, US0010001.</summary>
        [Newtonsoft.Json.JsonProperty("companyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompanyCode { get; set; }= default!;
    
        /// <summary>Identifier of the currency. This is the 3-letter ISO 4217 code of the currency.</summary>
        [Newtonsoft.Json.JsonProperty("currencyId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrencyId { get; set; }= default!;
    
        /// <summary>Contains bank sort code or iban branch identifier for the account</summary>
        [Newtonsoft.Json.JsonProperty("sortCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SortCode { get; set; }= default!;
    
        /// <summary>Represents the International Bank Account Number (IBAN) of the account.  E.g. GB29 NWBK 6016 1331 9268 19</summary>
        [Newtonsoft.Json.JsonProperty("accountIBAN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AccountIBAN { get; set; }= default!;
    
        /// <summary>Real-time balance including all authorised transactions posted against the account and, unless it is a nostro or internal account, unauthorised debit entries.</summary>
        [Newtonsoft.Json.JsonProperty("workingBalance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WorkingBalance { get; set; }= default!;
    
        /// <summary>The date the account is opened.</summary>
        [Newtonsoft.Json.JsonProperty("openingDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? OpeningDate { get; set; }= default!;
    
        /// <summary>The company in which payment is processed</summary>
        [Newtonsoft.Json.JsonProperty("companyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompanyName { get; set; }= default!;
    
        /// <summary>Indicates the preferred product of the arrangement contract. This is required for only new arrangements and product change is not permitted</summary>
        [Newtonsoft.Json.JsonProperty("preferredProduct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PreferredProduct { get; set; }= default!;
    
        /// <summary>Indicates to position of the preferred product of the arrangement contract. This is required for only new arrangements and product change is not permitted</summary>
        [Newtonsoft.Json.JsonProperty("preferredProductPosition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PreferredProductPosition { get; set; }= default!;
    
        /// <summary>Indicates the label of the Preferred Product of the Arrangement contract. This is required for only new arrangements and product change is not permitted</summary>
        [Newtonsoft.Json.JsonProperty("preferredProductLabel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PreferredProductLabel { get; set; }= default!;
    
        /// <summary>The act of permitting, especially in giving formal consent to access a particular file or repository.</summary>
        [Newtonsoft.Json.JsonProperty("permission", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Permission { get; set; }= default!;
    
        /// <summary>Real-time balance including all authorised transactions posted against the account, excluding any entries with a future processing date.</summary>
        [Newtonsoft.Json.JsonProperty("onlineActualBalance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OnlineActualBalance { get; set; }= default!;
    
        /// <summary>Available balance of the account which is the projected balance which includes the net movements of both debits and credits against the account.</summary>
        [Newtonsoft.Json.JsonProperty("availableBalance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AvailableBalance { get; set; }= default!;
    
        /// <summary>Contains the maximum amount available to be drawn</summary>
        [Newtonsoft.Json.JsonProperty("availableBalanceWithLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AvailableBalanceWithLimit { get; set; }= default!;
    
        /// <summary>Contains the aggregate outstanding principal amount thereof after giving effect to any borrowings and prepayments or repayments of Committed Loans</summary>
        [Newtonsoft.Json.JsonProperty("outstandingAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OutstandingAmount { get; set; }= default!;
    
        /// <summary>The amount paid out.</summary>
        [Newtonsoft.Json.JsonProperty("paidOutAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PaidOutAmount { get; set; }= default!;
    
        /// <summary>Status of the arrangement. E.g. AUTH, CLOSE, UNAUTH etc.</summary>
        [Newtonsoft.Json.JsonProperty("arrangementStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ArrangementStatus { get; set; }= default!;
    
        /// <summary>Contains the amount borrowed or the part of the amount borrowed which remains unpaid</summary>
        [Newtonsoft.Json.JsonProperty("totalPrincipal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalPrincipal { get; set; }= default!;
    
        /// <summary>The reference which is provided to the beneficiary/ creditor by the originator of payment</summary>
        [Newtonsoft.Json.JsonProperty("customerReference", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CustomerReference { get; set; }= default!;
    
        /// <summary>Specifies the eStatement for the account</summary>
        [Newtonsoft.Json.JsonProperty("statement", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Statement { get; set; }= default!;
    
        /// <summary>Contains the id associated to the connect reference respective to a transaction of the account</summary>
        [Newtonsoft.Json.JsonProperty("connectionId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConnectionId { get; set; }= default!;
    
        /// <summary>Contains the last updated balances details</summary>
        [Newtonsoft.Json.JsonProperty("balancesLastUpdated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BalancesLastUpdated { get; set; }= default!;
    
        /// <summary>Contains the list of last updated transactions</summary>
        [Newtonsoft.Json.JsonProperty("transactionsLastUpdated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TransactionsLastUpdated { get; set; }= default!;
    
        /// <summary>Indicates the logo of the bank</summary>
        [Newtonsoft.Json.JsonProperty("bankLogo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BankLogo { get; set; }= default!;
    
        /// <summary>Contains the name of the external source provider for the customer</summary>
        [Newtonsoft.Json.JsonProperty("extSourceProvider", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExtSourceProvider { get; set; }= default!;
    
        /// <summary>Identifier of the customer</summary>
        [Newtonsoft.Json.JsonProperty("customerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CustomerId { get; set; }= default!;
    
        /// <summary>Contains the connection status of the transaction</summary>
        [Newtonsoft.Json.JsonProperty("connectionStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConnectionStatus { get; set; }= default!;
    
        /// <summary>Contains the connection sub status of the transaction</summary>
        [Newtonsoft.Json.JsonProperty("connectionSubStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConnectionSubStatus { get; set; }= default!;
    
        /// <summary>Denotes the next refresh time</summary>
        [Newtonsoft.Json.JsonProperty("nextRefreshAvailableAt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NextRefreshAvailableAt { get; set; }= default!;
    
        /// <summary>Contains the swift reference of the account</summary>
        [Newtonsoft.Json.JsonProperty("acctSwiftRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctSwiftRef { get; set; }= default!;
    
        /// <summary>Denotes the external account number</summary>
        [Newtonsoft.Json.JsonProperty("extAccountNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExtAccountNumber { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("paymentTemplates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<PaymentTemplates>? PaymentTemplates { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PaymentTemplates 
    {
        /// <summary>Contains the template used for payment transactions</summary>
        [Newtonsoft.Json.JsonProperty("paymentTemplate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentTemplate { get; set; }= default!;
    
    
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