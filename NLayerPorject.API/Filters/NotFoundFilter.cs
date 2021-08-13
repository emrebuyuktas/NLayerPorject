using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLayerProject.Core.DTOs;
using NLayerProject.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerPorject.API.Filters
{
    public class NotFoundFilter: ActionFilterAttribute
    {
        private readonly IProductService _productService;

        public NotFoundFilter(IProductService productService)
        {
            _productService = productService;
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id = (int)context.ActionArguments.Values.FirstOrDefault();
            var product = await _productService.GetByIdAsync(id);
            if (product!=null)
            {
                await next();
            }
            ErrorDto errorDto = new ErrorDto();
            errorDto.Status = 404;
            errorDto.Errors.Add($"Id'si {id} olan bir ürün bulunamadı.");
            context.Result = new NotFoundObjectResult(errorDto);
        }
    }
}
