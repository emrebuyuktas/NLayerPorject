using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Core.DTOs
{
    public class CategoryWithProductDto:CategoryDto
    {
        public ICollection<ProductDto> Products { get; set; }
    }
}
