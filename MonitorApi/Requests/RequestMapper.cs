using AutoMapper;
using Monitor.DomainDrivenDesign;

namespace Monitor.Requests
{
    public static class RequestMapper
    {
        static RequestMapper()
        {
            ConfigMapper = new MapperConfiguration(config =>
            {
                config.CreateMap<ServiceEnvironmentStatusLog, ServiceEnvironmentStatusLogRequest>();

                config.CreateMap<ServiceEnvironmentStatusLogRequest, ServiceEnvironmentStatusLog>();
            }).CreateMapper();
        }

        public static IMapper ConfigMapper { get; }
    }
}
