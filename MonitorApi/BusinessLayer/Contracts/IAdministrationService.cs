using System.Threading.Tasks;
using Monitor.BusinessLayer.Responses;
using Monitor.DomainDrivenDesign;

namespace Monitor.BusinessLayer.Contracts
{
    public interface IAdministrationService : IService
    {
        Task<ISingleResponse<ServiceEnvironmentStatusLog>> CreateServiceEnvironmentStatusLogAsync(ServiceEnvironmentStatusLog entity, int? serviceEnvironmentID);
    }
}
