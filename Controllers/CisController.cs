using System.Xml.Serialization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;



namespace api_dotnet.Controllers
{
  [Route("api/cis")]
  [ApiController]
  public class CisController : ControllerBase
  {
    private CiDao _ci;
    public CisController(CiDao cidao)
    {
      _ci = cidao;
    }

    [HttpGet]
    public IEnumerable<dynamic> Get()
    {
      return _ci.list();
    }
  }
}