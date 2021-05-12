using System.Collections.Generic;

namespace E_shop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        { 
            new Category
            {
                CategoryID = 1, CategoryName = "Hard Candy", CategoryDescription="Awesome hard candy"
            },

            new Category
            {
                CategoryID = 2, CategoryName = "Chocolate Candy", CategoryDescription="Scuptious Chocolate candy"
            },

             new Category
            {
                CategoryID = 3, CategoryName = "Fruit Candy", CategoryDescription="Sweet and sour fruit candy"
            }

        };

    }
}
