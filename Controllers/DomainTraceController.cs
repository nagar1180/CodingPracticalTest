using CodingPracticalTest.Model;
using CodingPracticalTest.Model.Request;
using CodingPracticalTest.Services.Contract;
using CodingPracticalTest.Services.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CodingPracticalTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomainTraceController : ApiControllerBase
    {
        private readonly ILogger<DomainTraceController> logger;
        private readonly IEnumerable<IDomainDetailService> services;
        public DomainTraceController(ILogger<DomainTraceController> logger, IEnumerable<IDomainDetailService> services)
        {
            this.logger = logger;
            this.services = services;
        }

        [HttpPost, Route("")]
        public async Task<IActionResult> Index([FromBody] RequestModel model)
        {
            try
            {
                if (IsValidDomainName(model.Address))
                {
                    if(model.Services == null || model.Services.Count == 0)
                    {
                        model.Services = new List<string> { Constants.GeoIp, Constants.RDAP, Constants.ReverseDNS };                        
                    }

                    var allTasks = new List<Task<DomainDetail>>();
                    foreach (var service in model.Services)
                    {
                        var task = GetService(service).GetDetails(model.Address);
                        allTasks.Add(task);
                    }

                    var result = await Task.WhenAll(allTasks);
                    return Ok(result);
                }
                return BadRequest("Invalid Domain Name or Ip Address");
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                return StatusCode(500, "Internal server error : Please contact api administrator");
            }            
        }

        private IDomainDetailService GetService(string service)
        {
            if(service.Equals(Constants.GeoIp ,StringComparison.OrdinalIgnoreCase))
            {
                return services.First(x => x.GetType() == typeof(GeoIpDomainDetailService));
            }
            else if (service.Equals(Constants.RDAP, StringComparison.OrdinalIgnoreCase))
            {
                return services.First(x => x.GetType() == typeof(RdapDomainDetailService));
            }
            else if (service.Equals(Constants.ReverseDNS, StringComparison.OrdinalIgnoreCase))
            {
                return services.First(x => x.GetType() == typeof(ReverseDNSDetailService));
            }
            throw new Exception("Invalid Service Name");
        }


        private bool IsValidDomainName(string name)
        {
            return Uri.CheckHostName(name) != UriHostNameType.Unknown;
        }
    }
}
