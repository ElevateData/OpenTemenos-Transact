using OpenTemenos.Transacts.Reference.AccountOfficers;
using OpenTemenos.Transacts.Reference.BalanceTypes;
using OpenTemenos.Transacts.Reference.Beneficiaries;
using OpenTemenos.Transacts.Reference.BICs;
using OpenTemenos.Transacts.Reference.Brokers;
using OpenTemenos.Transacts.Reference.BundleRates;
using OpenTemenos.Transacts.Reference.Categories;
using OpenTemenos.Transacts.Reference.ChequeTypes;
using OpenTemenos.Transacts.Reference.CollateralClassifications;
using OpenTemenos.Transacts.Reference.Companies;
using OpenTemenos.Transacts.Reference.Countries;
using OpenTemenos.Transacts.Reference.Currencies;
using OpenTemenos.Transacts.Reference.Dates;
using OpenTemenos.Transacts.Reference.Dealers;
using OpenTemenos.Transacts.Reference.IBANs;
using OpenTemenos.Transacts.Reference.InterestBases;
using OpenTemenos.Transacts.Reference.InterestRates;
using OpenTemenos.Transacts.Reference.Lookups;
using OpenTemenos.Transacts.Reference.NationalIds;
using OpenTemenos.Transacts.Reference.OrganizationStructures;
using OpenTemenos.Transacts.Reference.PeriodDates;
using OpenTemenos.Transacts.Reference.PortfolioAccounts;
using OpenTemenos.Transacts.Reference.Products;
using OpenTemenos.Transacts.Reference.RoundingRules;
using OpenTemenos.Transacts.Reference.TransactionCodes;
using OpenTemenos.Transacts.Reference.Treasuries;
using OpenTemenos.Transacts.Reference.UsBenOwnerTypes;
using OpenTemenos.Transacts.Reference.UsCounties;
using OpenTemenos.Transacts.Reference.UsCovenants;
using OpenTemenos.Transacts.Reference.UsCustomerRatings;
using OpenTemenos.Transacts.Reference.UsCustomerSuffixs;
using OpenTemenos.Transacts.Reference.UsCustomerTitles;
using OpenTemenos.Transacts.Reference.UsFdicClassCodes;
using OpenTemenos.Transacts.Reference.UsHoldTypes;
using OpenTemenos.Transacts.Reference.UsIdDocuments;
using OpenTemenos.Transacts.Reference.UsIndustries;
using OpenTemenos.Transacts.Reference.UsSectors;
using OpenTemenos.Transacts.Reference.UsSortCodes;
using OpenTemenos.Transacts.Reference.UsStates;

namespace OpenTemenos.Transacts;

//TODO: Rename Transact.IReferenceClient methods
public interface IReferenceClient
{
    public IAccountOfficerService AccountOfficerService { get; }
    public IBalanceTypeService BalanceTypeService { get; }
    public IBeneficiaryService BeneficiaryService { get; }
    public IBICService BICService { get; }
    public IBrokerService BrokerService { get; }
    public IBundleRateService BundleRateService { get; }
    public ICategoryService CategoryService { get; }
    public IChequeTypeService ChequeTypeService { get; }
    public ICollateralClassificationService CollateralClassificationService { get; }
    public ICompanyService CompanyService { get; }
    public ICountryService CountryService { get; }
    public ICurrencyService CurrencyService { get; }
    public IDateService DateService { get; }
    public IDealerService DealerService { get; }
    public IIBANService IBANService { get; }
    public IInterestBaseService InterestBaseService { get; }
    public IInterestRateService InterestRateService { get; }
    public ILookupService LookupService { get; }
    public INationalIdService NationalIdService { get; }
    public IOrganizationStructureService OrganizationStructureService { get; }
    public IPeriodDateService PeriodDateService { get; }
    public IPortfolioAccountService PortfolioAccountService { get; }
    public IProductService ProductService { get; }
    public IRoundingRuleService RoundingRuleService { get; }
    public ITransactionCodeService TransactionCodeService { get; }
    public ITreasuryService TreasuryService { get; }
    public IUsBenOwnerTypeService UsBenOwnerTypeService { get; }
    public IUsCountyService UsCountyService { get; }
    public IUsCovenantService UsCovenantService { get; }
    public IUsCustomerRatingService UsCustomerRatingService { get; }
    public IUsCustomerSuffixService UsCustomerSuffixService { get; }
    public IUsCustomerTitleService UsCustomerTitleService { get; }
    public IUsFdicClassCodeService UsFdicClassCodeService { get; }
    public IUsHoldTypeService UsHoldTypeService { get; }
    public IUsIdDocumentService UsIdDocumentService { get; }
    public IUsIndustryService UsIndustryService { get; }
    public IUsSectorService UsSectorService { get; }
    public IUsSortCodeService UsSortCodeService { get; }
    public IUsStateService UsStateService { get; }

}