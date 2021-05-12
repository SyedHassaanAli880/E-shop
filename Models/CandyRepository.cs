using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_shop.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Candy> GetAllCandy => new List<Candy>()
        {
            new Candy
            {
                CandyID = 1, Name = "Assorted hard candy", Price = 4.95M, Description="description of Assorted hard candy",
                Category = _categoryRepository.GetAllCategories.ToList()[0], ImageURL="https://media.istockphoto.com/photos/lollipops-candies-and-sweet-sugar-jelly-multicolored-picture-id1145250337?k=6&m=1145250337&s=612x612&w=0&h=QIYD9HRUdTikfpjEM0pQFWWfqsyvCmSmS_C6D90qa2c=",
                IsInStock = true, IsOnSale = false, ImageThumbnailURL = "https://www.google.com.pk/url?sa=i&url=https%3A%2F%2Fwww.hangar-12.com%2Fblog%2Fthe-sweetest-candy-trends&psig=AOvVaw2N_CzOj6ghgANa2HJyoZnb&ust=1620862519277000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCLjJv8flwvACFQAAAAAdAAAAABAN"
            },

            new Candy
            {
                CandyID = 2, Name = "Assorted chocoloate candy", Price = 4.99M, Description="description of Assorted chocoloate candy",
                Category = _categoryRepository.GetAllCategories.ToList()[1], ImageURL="https://www.google.com.pk/url?sa=i&url=https%3A%2F%2Funsplash.com%2Fs%2Fphotos%2Fcandy&psig=AOvVaw2N_CzOj6ghgANa2HJyoZnb&ust=1620862519277000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCLjJv8flwvACFQAAAAAdAAAAABAT",
                IsInStock = true, IsOnSale = false, ImageThumbnailURL = "https://www.google.com.pk/url?sa=i&url=https%3A%2F%2Fwww.dreamstime.com%2Fphotos-images%2Fcandy-buffet.html&psig=AOvVaw2N_CzOj6ghgANa2HJyoZnb&ust=1620862519277000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCLjJv8flwvACFQAAAAAdAAAAABAZ"
            },

            new Candy
            {
                CandyID = 3, Name = "Assorted fruit candy", Price = 5.99M, Description="description of Assorted fruit candy",
                Category = _categoryRepository.GetAllCategories.ToList()[2], ImageURL="https://www.google.com.pk/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FHard_candy&psig=AOvVaw2N_CzOj6ghgANa2HJyoZnb&ust=1620862519277000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCLjJv8flwvACFQAAAAAdAAAAABAe",
                IsInStock = true, IsOnSale = false, ImageThumbnailURL = "https://www.google.com.pk/url?sa=i&url=https%3A%2F%2Fwww.gettyimages.com%2Fphotos%2Fcandy&psig=AOvVaw2N_CzOj6ghgANa2HJyoZnb&ust=1620862519277000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCLjJv8flwvACFQAAAAAdAAAAABAj"
            }
        };

        public IEnumerable<Candy> GetAllCandyOnSale => throw new NotImplementedException();

        public Candy GetCandyByID(int candyID)
        {
            return GetAllCandy.FirstOrDefault(c=> c.CandyID == candyID);
        }
    }
}
