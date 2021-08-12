using NLayerProject.Core.Entity;
using NLayerProject.Core.Repositories;
using NLayerProject.Core.Services;
using NLayerProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Service.Services
{
    public class CategorySevice : Service<Category>, ICategoryService
    {
        public CategorySevice(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Category> GetWithProductsById(int categoryId)
        {
            return await _unitOfWork.Categories.GetWithProductsById(categoryId);
        }
    }
}
