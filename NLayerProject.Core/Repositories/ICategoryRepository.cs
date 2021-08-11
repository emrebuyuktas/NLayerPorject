using NLayerProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Repositories
{
     public interface ICategoryRepository:IRepository<Category>
    {
        Task<Category> GetWithProductsById(int categoryId);
    }
}
