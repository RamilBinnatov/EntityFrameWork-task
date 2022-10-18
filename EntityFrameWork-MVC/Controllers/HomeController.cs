using EntityFrameWork_MVC.Data;
using EntityFrameWork_MVC.Models;
using EntityFrameWork_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

           List<Slider> sliders = _context.Sliders.ToList();
            SliderDetail sliderDetail = _context.SliderDetails.FirstOrDefault();

            HomeVM model = new HomeVM
            {
                sliders = sliders,
                SliderDetail = sliderDetail
            };
            
            return View(model);
        }

    }
}
