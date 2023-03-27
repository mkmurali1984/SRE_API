using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SRE_API.Models;
using SRE_API.Services;

namespace SRE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        private readonly PropertiesServices propertiesServices;
        public PropertiesController(PropertiesServices propertiesServices)
        {
            this.propertiesServices = propertiesServices;
        }

        [HttpGet]
        public async Task<List<PropertiesModel>> Get()
        {
            return await propertiesServices.GettheProperties();
        }
    }
}
