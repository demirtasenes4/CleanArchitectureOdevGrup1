﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OdevGrup1.Presentation.Abstraction;
[Route("api/[controller]/[action]")]
[ApiController]

public class ApiController : ControllerBase
{
    public readonly IMediator _mediator;

    public ApiController(IMediator mediator)
    {
        _mediator = mediator;
    }
}
