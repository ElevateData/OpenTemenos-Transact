using OpenTemenos.Transacts.Holding.UsDashboards;
using OpenTemenos.Transacts.Holding.UsSafeDeposits;

namespace OpenTemenos.Transacts;

public interface IUsModelBank
{
    public IUsDashboardService HoldingSummaryService { get; }
    //public IUsLoanService LoanService { get; }
    //public IUsAccountService AccountService { get; }
    //public IUsDepositService DepositService { get; }
    public IUsSafeDepositService SafeDepositService { get; }
}
