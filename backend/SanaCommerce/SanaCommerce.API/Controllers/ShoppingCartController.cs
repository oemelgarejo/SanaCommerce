using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SanaCommerce.Application.Commands;
using SanaCommerce.Application.DTOs;
using SanaCommerce.Application.Queries;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SanaCommerce.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ShoppingCartController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ShoppingCartRequestDto shoppingCartItems)
        {
            var command = new CreateOrderCommand.Command(shoppingCartItems);
            var order = await _mediator.Send(command);
            
            return Ok(order);
        }
    }
}

