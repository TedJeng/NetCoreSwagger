using Api.Repository.Model;
using Api.Repository.Service;
using ApiWithSwagger.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SecuringWebApiUsingApiKey.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWithSwagger.Controllers
{
    [ApiKey]
    [ApiController]
    [Route("[controller]")]
    public class AdventureWorksController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<AdventureWorksController> _logger;
        private IApiService _service;
        private Map _map;

        public AdventureWorksController(IApiService service, ILogger<AdventureWorksController> logger, Map map)
        {
            _service = service;
            _map = map;
            _logger = logger;
        }

        [HttpGet]
        [Route("Department/{DepartmentId}")]
        public async Task<ActionResult<string>> GetDepartment(int DepartmentId)
        {
            return _map.Serialize(await _service.GetHRDepartment(DepartmentId));
        }
    }
}
