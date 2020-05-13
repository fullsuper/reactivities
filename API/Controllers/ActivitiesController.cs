using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Activities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route ("api/[Controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase {
        private readonly IMediator _mediator;
        public ActivitiesController (IMediator mediator) {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Activity>> List() => await _mediator.Send(new List.Query());

        [HttpGet("{id}")]
        public async Task<Activity> Details(Guid id) => await _mediator.Send(new Details.Query(id));

        [HttpPost]
        [Route("hello")]
        public async Task<ActionResult<Unit>> Create(Create.Command command) => await _mediator.Send(command);
    }
}