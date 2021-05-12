using E_shop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_shop.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepository _candyRepository;

        private readonly ICategoryRepository _categoryRepository;

        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            _candyRepository = candyRepository; 
            
            _categoryRepository = categoryRepository;
        }

        public IActionResult CandyList()
        {
            return View(_candyRepository.GetAllCandy);
        }
    }
}
