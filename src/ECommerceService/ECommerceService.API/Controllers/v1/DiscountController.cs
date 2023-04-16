using ECommerceService.API.Models;
using ECommerceService.Application.Features.Commands.CreateDiscount;
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

        #region Create Discount
        [HttpPost("creatediscount")]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(ResponseModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateDiscount(CreateDiscountCommand createDiscountCommand)
        {
            var response = new ResponseModel() { Success = true, Message = "Başarılı", Data = await _mediator.Send(createDiscountCommand) };
            return Ok(response);
        }
        #endregion
    }
}
