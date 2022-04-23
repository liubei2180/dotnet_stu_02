using Microsoft.AspNetCore.Mvc;
using MediatR;


namespace Controllers
{
    public abstract class ApiController: ControllerBase {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>(); // ??= 有值则返回，无值则请求获取值后，赋值给_mediator，并返回
    }

}
