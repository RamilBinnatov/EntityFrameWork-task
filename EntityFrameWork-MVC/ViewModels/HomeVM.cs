using EntityFrameWork_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork_MVC.ViewModels
{
    public class HomeVM
    {
        public List<Slider> sliders { get; set; }
        public SliderDetail SliderDetail { get; set; }
    }
}
