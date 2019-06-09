namespace ServiceMonitor.Watchers
{
    public class WatchResponse : IWatchResponse
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public string StackTrace { get; set; }
    }

    public interface IWatchResponse
    {
        bool Success { get; set; }

        string Message { get; set; }

        string StackTrace { get; set; }
    }
}
