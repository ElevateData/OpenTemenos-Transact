using OpenTemenos.Transacts.Product.Customers;
using OpenTemenos.Transacts.Product.ExternalProducts;
using OpenTemenos.Transacts.Product.LimitProducts;
using OpenTemenos.Transacts.Product.MarketingCatalogues;
using OpenTemenos.Transacts.Product.UserAdmins;

namespace OpenTemenos.Transacts;

//TODO: Rename Transact.IProductClient methods
public interface IProductClient
{
    public ICustomerService CustomerService { get; }
    public IExternalProductService ExternalProductService { get; }
    public ILimitProductService LimitProductService { get; }
    public IMarketingCatalogueService MarketingCatalogueService { get; }
    public IUserAdminService UserAdminService { get; }

}