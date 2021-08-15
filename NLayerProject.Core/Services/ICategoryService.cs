﻿using NLayerProject.Core.DTOs;
using NLayerProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Services
{
    public interface ICategoryService:IService<Category>
    {
        Task<Category> GetWithProductsById(int categoryId);
    }
}
