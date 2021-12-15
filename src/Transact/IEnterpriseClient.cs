using OpenTemenos.Transacts.Enterprise.Pricings;

namespace OpenTemenos.Transacts;

/// <summary>
/// Enterprise product pricing
/// </summary>
public interface IEnterpriseClient
{
    public IPricingService EnterpriseProductPricingService { get; }
}