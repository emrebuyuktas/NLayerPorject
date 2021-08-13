using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NLayerProject.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerPorject.API.Filters
{
    public class ValidationFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                ErrorDto errorDto = new ErrorDto();
                errorDto.Status = 400;
                IEnumerable<ModelError> modelError = context.ModelState.Values.SelectMany(e => e.Errors);
                modelError.ToList().ForEach(e =>
                {
                    errorDto.Errors.Add(e.ErrorMessage);
                });
                context.Result = new BadRequestObjectResult(errorDto);
            }
        }
    }
}
