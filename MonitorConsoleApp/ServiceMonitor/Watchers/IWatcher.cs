
using System.Threading.Tasks;

namespace ServiceMonitor.Watchers
{
    public interface IWatcher
    {
        string ActionName { get; }

        Task<WatchResponse> WatchAsync(WatcherParameter parameter);
    }
}
