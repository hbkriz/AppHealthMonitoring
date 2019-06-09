using System.Collections.Generic;

namespace ServiceMonitor.Watchers
{
    public class WatcherParameter
    {
        public WatcherParameter()
        {
        }

        public WatcherParameter(IDictionary<string, string> dictionary)
        {
            Values = dictionary;
        }

        public IDictionary<string, string> Values { get; set; }
    }
}
