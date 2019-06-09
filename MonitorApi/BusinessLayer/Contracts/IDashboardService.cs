using System.Threading.Tasks;
using Monitor.BusinessLayer.Responses;
using Monitor.DomainDrivenDesign.DataContracts;
using Monitor.DomainDrivenDesign;

namespace Monitor.BusinessLayer.Contracts
{
    public interface IDashboardService : IService
    {
        Task<IListResponse<ServiceWatcherItemDto>> GetActiveServiceWatcherItemsAsync();

        Task<IListResponse<ServiceStatusDetailDto>> GetServiceStatusesAsync(string userName);

        Task<ISingleResponse<ServiceEnvironmentStatus>> GetServiceStatusAsync(ServiceEnvironmentStatus entity);
    }
}
