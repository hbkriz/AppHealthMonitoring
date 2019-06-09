using Newtonsoft.Json;

namespace ServiceMonitor
{
    public class ServiceMonitorSerializer : ISerializer
    {
        public string Serialize<T>(T obj)
            => JsonConvert.SerializeObject(obj);

        public T Deserialze<T>(string source)
            => JsonConvert.DeserializeObject<T>(source);
    }

    public interface ISerializer
    {
        string Serialize<T>(T obj);

        T Deserialze<T>(string source);
    }
}
