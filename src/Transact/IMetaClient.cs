using OpenTemenos.Transacts.Meta.Apis;
using OpenTemenos.Transacts.Meta.DwExportProperties;
using OpenTemenos.Transacts.Meta.Menus;
using OpenTemenos.Transacts.Meta.Payments;
using OpenTemenos.Transacts.Meta.Queries;
using OpenTemenos.Transacts.Meta.Screens;
using OpenTemenos.Transacts.Meta.Tables;
using OpenTemenos.Transacts.Meta.UserAdministrationInternals;
using OpenTemenos.Transacts.Meta.VirtualTables;

namespace OpenTemenos.Transacts;

public interface IMetaClient
{
    public IApiService ApiService { get; }
    public IDwExportPropertyService DwExportPropertyService { get; }
    public IMenuService MenuService { get; }
    public IPaymentService PaymentService { get; }
    public IQueryService QueryService { get; }
    public IScreenService ScreenService { get; }
    public ITableService TableService { get; }
    public IUserAdministrationInternalService UserAdministrationInternalService { get; }
    public IVirtualTableService VirtualTableService { get; }

}