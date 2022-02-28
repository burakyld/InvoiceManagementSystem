using IMS.Application.Features.Commands.Buildings.AddApartment;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMS.API.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        public readonly IMediator _mediator;
        public ApartmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddApartment(AddApartmentCommand addApartmentCommand)
        {
            var result = await _mediator.Send(addApartmentCommand);

            return Ok(result);
        }
    }
}
