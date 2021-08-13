using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Core.DTOs
{
    public class ErrorDto
    {
        public List<string> Errors { get; set; }
        public int Status { get; set; }

        public ErrorDto()
        {
            Errors = new List<string>();
        }
    }
}
