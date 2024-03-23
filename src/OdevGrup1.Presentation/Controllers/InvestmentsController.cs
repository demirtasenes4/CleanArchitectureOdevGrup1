using Microsoft.AspNetCore.Mvc;
using OdevGrup1.Presentation.Abstraction;

namespace OdevGrup1.Presentation.Controllers;
internal class InvestmentsController : ApiController
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok("Api çalışıyor");
    }
}
