using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SanaCommerce.API.Controllers;
using SanaCommerce.API.DTOs;
using SanaCommerce.Application.Commands;
using SanaCommerce.Application.DTOs;
using SanaCommerce.Application.Queries;

namespace SanaCommerce.Tests
{
	public class OrdersControllerTests
	{
        private readonly Mock<IMediator> _mediatorMock;
        private readonly OrdersController _controller;

        public OrdersControllerTests()
		{
            _mediatorMock = new Mock<IMediator>();
            _controller = new OrdersController(_mediatorMock.Object);
        }

        [Fact]
        public async Task GetAllOrders_ReturnsOkResult()
        {
            var expectedOrders = new List<OrderDto> { new OrderDto() };
            var expectedTotalPages = 1;
            _mediatorMock.Setup(m => m.Send(It.IsAny<GetAllOrdersQuery.Query>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync((expectedOrders, expectedTotalPages));

            var result = await _controller.GetAllOrders(1);

            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<OrderResponse>(okResult.Value);
            Assert.Equal(expectedOrders, returnValue.Orders);
            Assert.Equal(expectedTotalPages, returnValue.TotalPages);
        }

        [Fact]
        public async Task Post_ReturnsOkResult()
        {
            var shoppingCartItems = new ShoppingCartRequestDto();
            var expectedOrder = new OrderDto();
            _mediatorMock.Setup(m => m.Send(It.IsAny<CreateOrderCommand.Command>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(expectedOrder);

            var result = await _controller.Post(shoppingCartItems);

            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(expectedOrder, okResult.Value);
        }
    }
}

