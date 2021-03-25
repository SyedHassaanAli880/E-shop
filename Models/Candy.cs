using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_shop.Models
{
    public class Candy
    {
        public int CandyID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public string ImageThumbnailURL { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsInStock { get; set; }
        public int CategoryID { get; set; }
        public Category Category{ get; set; }

    }
}
