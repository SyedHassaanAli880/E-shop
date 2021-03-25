using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_shop.Models
{
    public interface ICandyRepository
    {
        IEnumerable<Candy> GetAllCandy { get; }

        IEnumerable<Candy> GetAllCandyOnSale { get; }

        Candy GetCandyByID(int candyID);
    }
}
