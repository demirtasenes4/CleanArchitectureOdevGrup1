using MediatR;
using Microsoft.AspNetCore.Mvc;
using OdevGrup1.Application.Features.Auth.Register;
using OdevGrup1.WebAPI.Abstraction;

namespace OdevGrup1.WebAPI.Controllers;

public class InvestmentsController : ApiController
{
    public InvestmentsController(IMediator mediator) : base(mediator)
    {
    }

}
