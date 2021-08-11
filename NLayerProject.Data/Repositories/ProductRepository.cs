using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Entity;
using NLayerProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }

        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Product> GetWithCategoryById(int productId)
        {
            return await appDbContext.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == productId);
            
        }
    }
}
