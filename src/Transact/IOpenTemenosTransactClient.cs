namespace OpenTemenos.Transacts;

public interface IOpenTemenosTransactClient
{
    public IEnterpriseClient Enterprise { get; }
    public IHoldingClient Holding { get; }
    public ILoanClient Loan { get; }
    public IMetaClient Meta { get; }
    public IMicroserviceClient Microservice { get; }
    public IOrderClient Order { get; }
    public IPartyClient Party { get; }
    public IProductClient Product { get; }
    public IReferenceClient Reference { get; }
    public ISystemClient System { get; }
}