using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaxiApp.Application.Contracts.Entities.Drivers;

namespace TaxiApp.HttpApi.Controllers
{
    [Route("api/[controller]")]
  [ApiController]
  public class DriversController : ControllerBase
  {
    private readonly IDriverAppService _driverAppService;

    public DriversController(IDriverAppService driverAppService)
    {
      _driverAppService = driverAppService;
    }




    [HttpGet("getlist")]
    public IActionResult GetList()
    {
      return Ok();
    }






  }
}
