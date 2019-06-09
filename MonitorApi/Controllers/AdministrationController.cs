using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Monitor.BusinessLayer.Contracts;
using Monitor.Requests;
using Monitor.Responses;

namespace Monitor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministrationController : ControllerBase
    {
        protected readonly ILogger Logger;
        protected readonly IAdministrationService Service;

        public AdministrationController(ILogger<AdministrationController> logger, IAdministrationService service)
        {
            Logger = logger;
            Service = service;
        }

        /// <response code="201">If service log was created succesfully</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpPost("ServiceEnvironmentStatusLog")]
        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> PostServiceEnvironmentStatusLogAsync([FromBody]ServiceEnvironmentStatusLogRequest request)
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(PostServiceEnvironmentStatusLogAsync));

            var response = await Service.CreateServiceEnvironmentStatusLogAsync(request.ToEntity(), request.ServiceEnvironmentID);

            return response.ToHttpCreatedResponse();
        }
    }
}
