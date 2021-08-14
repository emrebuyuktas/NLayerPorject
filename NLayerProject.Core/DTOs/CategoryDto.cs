using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NLayerProject.Core.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} alanı boş bırakılamaz")]
        public string Name { get; set; }
    }
}
