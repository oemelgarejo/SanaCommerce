using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SanaCommerce.API.DTOs;
using SanaCommerce.Application.Commands;
using SanaCommerce.Application.DTOs;
using SanaCommerce.Application.Queries;

namespace SanaCommerce.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Endpoint for get all products with 10 records per page
        /// </summary>
        /// <param name="pageNumber">Number of page</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllProducts(int? pageNumber)
        {
            int page = pageNumber ?? 1;
            var query = new GetAllProductsQuery.Query(page);
            var (products, totalPages) = await _mediator.Send(query);
            var response = new ProductResponse
            {
                Products = products,
                TotalPages = totalPages
            };
            return Ok(response);
        }


        /// <summary>
        /// Create a new product
        /// </summary>
        /// <param name="productDto">Dto for product</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ProductDto productDto)
        {
            try
            {
                var command = new CreateProductCommand.Command(productDto);
                ProductDto productCreated = await _mediator.Send(command);
                return Ok(productCreated);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

    }
}

