using MediatR;
using Microsoft.AspNetCore.Mvc;
using OdevGrup1.Presentation.Abstraction;

namespace OdevGrup1.Presentation.Controllers;
internal class InvestmentsController : ApiController
{
    public InvestmentsController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok("Api çalışıyor");
    }
}
