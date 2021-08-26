using CodingPracticalTest.Model.Request;
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
        public DomainTraceController(ILogger<DomainTraceController> logger)
        {
            this.logger = logger;
        }

        [HttpPost, Route("")]
        public async Task<IActionResult> Index([FromBody] IEnumerable<RequestModel> model)
        {
            try
            {  
                if (model.Count() > 0)
                {
                    List<Task<string>> allTasks = new List<Task<string>>();
                    HttpClient client = new HttpClient();
                    foreach (var item in model)
                    {
                        if (ModelState.IsValid)
                        {
                            var task = client.GetStringAsync(item.Address);
                            allTasks.Add(task);
                        }                      
                    }
                    
                    string[] result = await Task.WhenAll(allTasks);
                    return Ok(result);
                }
                return BadRequest("At least one address should provide");
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                return StatusCode(500, "Internal server error : Please contact api administrator");
            }            
        }       
    }
}
