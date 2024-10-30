using Microsoft.AspNetCore.Mvc;
using NETCore.DependencyInjector.Services;

namespace NETCore.DependencyInjector.Controllers
{
    [Route("api/[controlle]")]
    [ApiController]
    public class SalesManagerController : ControllerBase
    {
        private readonly IPOSFactory _posFactory;

        public SalesManagerController(IPOSFactory posFactory)
        {
            _posFactory = posFactory;
        }

        [HttpPost("POS")]
        public IActionResult Sales(string creatureType)
        {
            var posService = _posFactory.Create(creatureType);
            var amount = posService.GetSalesAmount();

            return Ok($"Sales amount is {amount} with {creatureType}");
        }
    }
}
