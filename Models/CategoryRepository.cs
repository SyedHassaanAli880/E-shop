using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_shop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Candy> GetAllCategories => new List<Category>
        {
            //new Category
        };
    }
}
