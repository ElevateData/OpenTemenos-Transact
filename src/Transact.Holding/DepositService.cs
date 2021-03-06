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

namespace OpenTemenos.Transacts.Holding.Deposits
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IDepositService
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the deposit Overview</summary>
        /// <param name="depositId">Indicates the Id of the deposit account</param>
        /// <param name="balanceTypes">Type of balance (e.g. current balance, credit interest accrued, deferred commission, etc.) as defined in the institution's accounting schemas.</param>
        /// <param name="page_size">The total number of records per page</param>
        /// <param name="page_start">The record from which the response should be displayed</param>
        /// <param name="page_token">Unique id expected to get as part of response from t24 on every enquiry request.</param>
        /// <param name="credentials">Username and password to authenticate the API against core-banking.</param>
        /// <param name="companyId">Identifier of the lead company of the underlying Entity/Company/Branch for the respective contract for customer data protection purposes. Example US0010001.</param>
        /// <param name="deviceId">Identifies the device type</param>
        /// <param name="userRole">User who initiated the transaction</param>
        /// <param name="disablePagination">Indicates the pagination header attributes availability. If set to 'true', it fetches all the data</param>
        /// <returns>DepositDetailsResponse</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [System.Obsolete]
        System.Threading.Tasks.Task<DepositDetailsResponse> GetDepositDetailsAsync(string depositId, string? balanceTypes = null, int? page_size = null, int? page_start = null, string? page_token = null, string? credentials = null, string? companyId = null, string? deviceId = null, string? userRole = null, bool? disablePagination = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
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
    
        /// <summary>Unique id expected to get as part of response from t24 on every enquiry request</summary>
        [Newtonsoft.Json.JsonProperty("page_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Page_token { get; set; }= default!;
    
    
    }
    
    /// <summary>DepositDetailsResponse</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class DepositDetailsResponse 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public QueryHeader? Header { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DepositDetailsResponseBody? Body { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class DepositDetailsResponseBody : System.Collections.ObjectModel.Collection<Anonymous>
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Anonymous 
    {
        /// <summary>Indicates the charge types which are applicable for the transaction. Example: CORRBKCHG</summary>
        [Newtonsoft.Json.JsonProperty("chargeTypes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ChargeTypes>? ChargeTypes { get; set; }= default!;
    
        /// <summary>Indicates tax charged to an account</summary>
        [Newtonsoft.Json.JsonProperty("taxRates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TaxRates>? TaxRates { get; set; }= default!;
    
        /// <summary>The charges or fees for this transaction</summary>
        [Newtonsoft.Json.JsonProperty("charges", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Charges>? Charges { get; set; }= default!;
    
        /// <summary>Indicates settlement conditions associated with the account</summary>
        [Newtonsoft.Json.JsonProperty("settlements", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Settlements>? Settlements { get; set; }= default!;
    
        /// <summary>Indicates an unique identifier of an account</summary>
        [Newtonsoft.Json.JsonProperty("arrangementId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ArrangementId { get; set; }= default!;
    
        /// <summary>Identifier of the currency. This is the 3-letter ISO 4217 code of the currency.</summary>
        [Newtonsoft.Json.JsonProperty("currencyId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrencyId { get; set; }= default!;
    
        /// <summary>Contains the date on which the transaction or payment gets initiated.</summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? StartDate { get; set; }= default!;
    
        /// <summary>Indicates maturity date of the contract</summary>
        [Newtonsoft.Json.JsonProperty("maturityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? MaturityDate { get; set; }= default!;
    
        /// <summary>Indicates a date or period within which an account gets matured</summary>
        [Newtonsoft.Json.JsonProperty("maturesIn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MaturesIn { get; set; }= default!;
    
        /// <summary>Indicates cooling off period for an account until which pre-closure can be triggered without incurring any fees or charges.</summary>
        [Newtonsoft.Json.JsonProperty("coolingOffDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? CoolingOffDate { get; set; }= default!;
    
        /// <summary>Indicates the period to which the BID and OFFER rates apply</summary>
        [Newtonsoft.Json.JsonProperty("term", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Term { get; set; }= default!;
    
        /// <summary>The monetary amount applied to the account</summary>
        [Newtonsoft.Json.JsonProperty("termAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TermAmount { get; set; }= default!;
    
        /// <summary>Indicates the Period beyond which a contract is cancelled if it not fully funded in case of deposit or fully disbursed in case of the loan</summary>
        [Newtonsoft.Json.JsonProperty("cancellationPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CancellationPeriod { get; set; }= default!;
    
        /// <summary>Indicates the early redemption fee that is associated during closure before account maturity</summary>
        [Newtonsoft.Json.JsonProperty("earlyRedemptionFee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? EarlyRedemptionFee { get; set; }= default!;
    
        /// <summary>Indicates fee charged for the withdrawals</summary>
        [Newtonsoft.Json.JsonProperty("withdrawalFee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WithdrawalFee { get; set; }= default!;
    
        /// <summary>Identifies the bid rate of the related currency for the defined time period</summary>
        [Newtonsoft.Json.JsonProperty("interestRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InterestRate { get; set; }= default!;
    
        /// <summary>Indicates interest accumulated for an account for the defined time period</summary>
        [Newtonsoft.Json.JsonProperty("accrualAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AccrualAmount { get; set; }= default!;
    
        /// <summary>The amount of interest that has been accrued</summary>
        [Newtonsoft.Json.JsonProperty("accruedInterest", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AccruedInterest { get; set; }= default!;
    
        /// <summary>Indicates if the payment is Customer (C) type or Bank (B) type</summary>
        [Newtonsoft.Json.JsonProperty("paymentType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentType { get; set; }= default!;
    
        /// <summary>Indicates the number of days within which an contract gets matured</summary>
        [Newtonsoft.Json.JsonProperty("maturityInDays", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MaturityInDays { get; set; }= default!;
    
        /// <summary>Indicates number of days remaining for maturity</summary>
        [Newtonsoft.Json.JsonProperty("remainingMaturityInDays", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RemainingMaturityInDays { get; set; }= default!;
    
        /// <summary>Indicates the total amount which will be lent or deposited for the term</summary>
        [Newtonsoft.Json.JsonProperty("commitmentAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CommitmentAmount { get; set; }= default!;
    
        /// <summary>Indicates the amount expected to be deposited by the customer</summary>
        [Newtonsoft.Json.JsonProperty("expectedBalance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExpectedBalance { get; set; }= default!;
    
        /// <summary>Flag to indicate whether withdrawals are applicable for the account</summary>
        [Newtonsoft.Json.JsonProperty("allowWithdrawal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AllowWithdrawal { get; set; }= default!;
    
        /// <summary>Indicates an unallocated credit amount to an account</summary>
        [Newtonsoft.Json.JsonProperty("unspecifiedCredit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UnspecifiedCredit { get; set; }= default!;
    
        /// <summary>Flag to indicate whether deposit is allowed to an account</summary>
        [Newtonsoft.Json.JsonProperty("allowDeposit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AllowDeposit { get; set; }= default!;
    
        /// <summary>Flag to indicate whether withdrawals are allowed to an unallocated fund available in the account</summary>
        [Newtonsoft.Json.JsonProperty("allowWithdrawalUnclearedCredit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AllowWithdrawalUnclearedCredit { get; set; }= default!;
    
        /// <summary>This is the BIC code of the institution where beneficiary holds an account</summary>
        [Newtonsoft.Json.JsonProperty("accountWithBankBIC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AccountWithBankBIC { get; set; }= default!;
    
        /// <summary>Indicates the sum of debit transaction amounts that are yet to be processed and placed as holds on accounts, but will not be available for use</summary>
        [Newtonsoft.Json.JsonProperty("pendingDeposit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PendingDeposit { get; set; }= default!;
    
        /// <summary>Name of the customer</summary>
        [Newtonsoft.Json.JsonProperty("customerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CustomerName { get; set; }= default!;
    
        /// <summary>Contains the total number of credits</summary>
        [Newtonsoft.Json.JsonProperty("totalCredits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TotalCredits { get; set; }= default!;
    
        /// <summary>Contains the total number of debits</summary>
        [Newtonsoft.Json.JsonProperty("totalDebits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TotalDebits { get; set; }= default!;
    
        /// <summary>Name of Joint Customer</summary>
        [Newtonsoft.Json.JsonProperty("jointCustomerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? JointCustomerName { get; set; }= default!;
    
        /// <summary>Indicates the total amount which will be lent or deposited for the term</summary>
        [Newtonsoft.Json.JsonProperty("commitmentBalance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CommitmentBalance { get; set; }= default!;
    
        /// <summary>Indicates the original total paid amount</summary>
        [Newtonsoft.Json.JsonProperty("lastPaidAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LastPaidAmount { get; set; }= default!;
    
        /// <summary>Date last payment was made</summary>
        [Newtonsoft.Json.JsonProperty("lastPaidDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? LastPaidDate { get; set; }= default!;
    
        /// <summary>Indicates the total due amount</summary>
        [Newtonsoft.Json.JsonProperty("totalDueAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalDueAmount { get; set; }= default!;
    
        /// <summary>Contains the total withdrawal amount on hold until payment execution date</summary>
        [Newtonsoft.Json.JsonProperty("pendingWithdrawals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PendingWithdrawals { get; set; }= default!;
    
    
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
    public partial class ChargeTypes 
    {
        /// <summary>Indicates the charge types which are applicable for the transaction. Example: CORRBKCHG</summary>
        [Newtonsoft.Json.JsonProperty("chargeType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ChargeType { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class TaxRates 
    {
        /// <summary>Indicates tax charged to an account</summary>
        [Newtonsoft.Json.JsonProperty("taxRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TaxRate { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Charges 
    {
        /// <summary>The frequency at which a payment is required to be generated</summary>
        [Newtonsoft.Json.JsonProperty("paymentFrequency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentFrequency { get; set; }= default!;
    
        /// <summary>Indicates Payment type set to an account</summary>
        [Newtonsoft.Json.JsonProperty("paymentTypeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentTypeName { get; set; }= default!;
    
        /// <summary>Indicates the Id of the product property</summary>
        [Newtonsoft.Json.JsonProperty("propertyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PropertyName { get; set; }= default!;
    
        /// <summary>Method chosen to make the payment</summary>
        [Newtonsoft.Json.JsonProperty("paymentMethod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentMethod { get; set; }= default!;
    
        /// <summary>Indicates the payment frequency associated with the charge</summary>
        [Newtonsoft.Json.JsonProperty("chargeSchedulePaymentValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ChargeSchedulePaymentValue { get; set; }= default!;
    
        /// <summary>Interest accrued for the specified period</summary>
        [Newtonsoft.Json.JsonProperty("dividentPaidYtd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DividentPaidYtd { get; set; }= default!;
    
        /// <summary>Deprecated - Interest accrued for the specified period</summary>
        [Newtonsoft.Json.JsonProperty("lastPaidDivident", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LastPaidDivident { get; set; }= default!;
    
        /// <summary>Indicates the end date of the interest period</summary>
        [Newtonsoft.Json.JsonProperty("periodEnding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? PeriodEnding { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Settlements 
    {
        /// <summary>Flag to indicate whether Payin Settlement instruction is required or not.Valid input is Yes or No.Default value is Yes.</summary>
        [Newtonsoft.Json.JsonProperty("payinSettlement", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PayinSettlement { get; set; }= default!;
    
        /// <summary>Indicates the Payin Settlement Account. The account from which funds are to be debited against the payment type.</summary>
        [Newtonsoft.Json.JsonProperty("payinAccountId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PayinAccountId { get; set; }= default!;
    
        /// <summary>Flag to indicate whether Payout Settlement instruction is required or not.Valid input is Yes or No.Default value is Yes.</summary>
        [Newtonsoft.Json.JsonProperty("payoutSettlement", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PayoutSettlement { get; set; }= default!;
    
        /// <summary>Indicates the Payout Settlement Account. The account into which funds are to be credited against the payment type.</summary>
        [Newtonsoft.Json.JsonProperty("payoutAccountId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PayoutAccountId { get; set; }= default!;
    
        /// <summary>The identifier of the product condition</summary>
        [Newtonsoft.Json.JsonProperty("propertyId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PropertyId { get; set; }= default!;
    
        /// <summary>The identifier of a condition that is used to build a product</summary>
        [Newtonsoft.Json.JsonProperty("propertyClassId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PropertyClassId { get; set; }= default!;
    
    
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