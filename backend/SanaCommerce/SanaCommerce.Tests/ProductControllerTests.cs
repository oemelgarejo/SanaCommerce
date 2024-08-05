using System;
using MediatR;
using Moq;
using SanaCommerce.API.Controllers;
using Moq;
using Microsoft.AspNetCore.Mvc;
using SanaCommerce.Application.Commands;
using SanaCommerce.Application.DTOs;
using SanaCommerce.Application.Queries;
using SanaCommerce.API.DTOs;

namespace SanaCommerce.Tests
{
	public class ProductControllerTests
	{
        private readonly Mock<IMediator> _mediatorMock;
        private readonly ProductsController _controller;

        public ProductControllerTests()
		{
            _mediatorMock = new Mock<IMediator>();
            _controller = new ProductsController(_mediatorMock.Object);
        }


        [Fact]
        public async Task GetAllProducts_ReturnsOkResult()
        {
            var expectedProducts = new List<ProductDto> { new ProductDto() };
            var expectedTotalPages = 1;
            _mediatorMock.Setup(m => m.Send(It.IsAny<GetAllProductsQuery.Query>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync((expectedProducts, expectedTotalPages));

            var result = await _controller.GetAllProducts(1);

            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<ProductResponse>(okResult.Value);
            Assert.Equal(expectedProducts, returnValue.Products);
            Assert.Equal(expectedTotalPages, returnValue.TotalPages);
        }

        [Fact]
        public async Task Post_ReturnsOkResult()
        {
            var productDto = new ProductDto();
            var expectedProduct = new ProductDto();
            _mediatorMock.Setup(m => m.Send(It.IsAny<CreateProductCommand.Command>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(expectedProduct);

            var result = await _controller.Post(productDto);

            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(expectedProduct, okResult.Value);
        }

        [Fact]
        public async Task Post_ReturnsBadRequestResult_WhenExceptionOccurs()
        {
            var productDto = new ProductDto();
            _mediatorMock.Setup(m => m.Send(It.IsAny<CreateProductCommand.Command>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new Exception("Test exception"));

            var result = await _controller.Post(productDto);

            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Test exception", badRequestResult.Value);
        }
    }
}

