﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using SanaCommerce.Application.Commands;
using SanaCommerce.Application.DTOs;
using SanaCommerce.Application.Queries;

namespace SanaCommerce.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders(int? pageNumber)
        {
            int page = pageNumber ?? 1;
            var query = new GetAllOrdersQuery.Query(page);
            var (orders, totalPages) = await _mediator.Send(query);
            return Ok(new
            {
                Orders = orders,
                TotalPages = totalPages
            });
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
