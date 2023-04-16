using ECommerceService.API.Models;
using ECommerceService.Application.Features.Commands.CreateCategory;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ECommerceService.API.Controllers.v1
{
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class CategoryController : ControllerBase
    {
        #region DI
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region Create Category
        [HttpPost("createcategory")]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(ResponseModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand createCategoryCommand)
        {
            var response = new ResponseModel() { Success = true, Message = "Başarılı", Data = await _mediator.Send(createCategoryCommand) };
            return Ok(response);
        }
        #endregion
    }
}
