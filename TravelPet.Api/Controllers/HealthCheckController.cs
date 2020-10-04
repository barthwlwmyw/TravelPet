using System;
using Microsoft.AspNetCore.Mvc;

namespace gp_approximation_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok($"TravelPet 🐕 API is up and running ({DateTime.UtcNow.ToString()}) - CI test");
        }
    }
}
