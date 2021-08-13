using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Core.DTOs
{
    public class ProductWithCategoryDto:ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
