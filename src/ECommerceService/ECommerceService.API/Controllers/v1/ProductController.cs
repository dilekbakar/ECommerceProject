using ECommerceService.API.Models;
using ECommerceService.Application.Features.Commands.CreateProduct;
using ECommerceService.Application.Features.Commands.UpdateProductPrice;
using ECommerceService.Application.Features.Queries.GetProducts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ECommerceService.API.Controllers.v1
{
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class ProductController : ControllerBase
    {
        #region DI
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region Get Products
        [HttpGet("getproducts")]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(ResponseModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetProducts(int page, int pageSize)
        {
            var response = new ResponseModel() { Success = true, Message = "Başarılı", Data = await _mediator.Send(new GetProductsQuery(page, pageSize)) };

            return Ok(response);
        }
        #endregion

        #region Create Products
        [HttpPost("createproducts")]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(ResponseModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateProducts(CreateProductCommand createProductCommand)
        {
            var response = new ResponseModel() { Success = true, Message = "Başarılı", Data = await _mediator.Send(createProductCommand) };
            return Ok(response);
        }
        #endregion

        #region Update Product Price
        [HttpPost("updateproductprice")]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(ResponseModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateProductPrice(UpdateProductPriceCommand updateProductPriceCommand)
        {
            var response = new ResponseModel() { Success = true, Message = "Başarılı", Data = await _mediator.Send(updateProductPriceCommand) };
            return Ok(response);
        }
        #endregion
    }
}
