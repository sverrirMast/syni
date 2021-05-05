using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SvinController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<SvinController> _logger;

        public SvinController(ILogger<SvinController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Svin> Get()
        {
        
            return Enumerable.Range(1, 5).Select(index => new Svin
            {
                
            })
            .ToArray();
        }
    }
}
