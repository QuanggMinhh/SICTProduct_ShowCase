using Domain.Entities;
using Infrastructure.Context;
using Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Implementation
{
    public class ProductTagRepository : GenericRepository<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(SICT_ShowCaseContext showCaseContext) : base(showCaseContext)
        {
        }
    }
}
