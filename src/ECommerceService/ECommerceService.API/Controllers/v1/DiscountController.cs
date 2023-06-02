using ECommerceService.API.Models;
using ECommerceService.Application.Features.Commands.CreateDiscount;
using ECommerceService.Application.Features.Queries.GetActiveDiscounts;
using ECommerceService.Application.Features.Queries.GetCategories;
using ECommerceService.Application.Features.Queries.GetDiscounts;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ECommerceService.API.Controllers.v1
{
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class DiscountController : ControllerBase
    {
        #region DI
        private readonly IMediator _mediator;

        public DiscountController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region Get Discounts
        [HttpGet("getdiscounts")]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(ResponseModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetDiscounts(int page, int pageSize)
        {
            var response = new ResponseModel() { Success = true, Message = "Başarılı", Data = await _mediator.Send(new GetDiscountsQuery(page, pageSize)) };

            return Ok(response);
        }
        #endregion

        #region Create Discount
        [HttpPost("createDiscount")]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(ResponseModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateDiscount(CreateDiscountCommand createDiscountCommand)
        {
            var response = new ResponseModel() { Success = true, Message = "Başarılı", Data = await _mediator.Send(createDiscountCommand) };
            return Ok(response);
        }
        #endregion

        #region Get ActiveDiscounts
        [HttpGet("getactvediscounts")]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(ResponseModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetActiveDiscounts(int page, int pageSize)
        {
            var response = new ResponseModel() { Success = true, Message = "Başarılı", Data = await _mediator.Send(new GetActiveDiscountsQuery(page, pageSize)) };

            return Ok(response);
        }
        #endregion
    }
}
