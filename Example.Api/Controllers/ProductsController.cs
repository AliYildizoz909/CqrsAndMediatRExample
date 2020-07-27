using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Api.Request;
using Example.Business.Application.Commands.ProductCommands;
using Example.Business.Application.Queries.ProductQueries;
using Example.DataAccess.Database;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NewProductRequest request)
        {
            await _mediator.Send(new NewProductCommand(request.Name, request.UnitPrice));
            return Ok();
        }
        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var detailDtos = await _mediator.Send(new ProductGetAllQuery());
            if (detailDtos == null)
            {
                return NotFound();
            }
            return Ok(detailDtos);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] ProductGetByIdRequest request)
        {
            var detailDto = await _mediator.Send(new ProductGetByIdQuery(request.Id));
            if (detailDto == null)
            {
                return BadRequest();
            }
            return Ok(detailDto);
        }
    }
}
