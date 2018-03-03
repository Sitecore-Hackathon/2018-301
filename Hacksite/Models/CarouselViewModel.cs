using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hacksite.Models
{
    public class CarouselViewModel
    {

        public List<CarouselItemModel> CarouselModelItems { get; set; }
        public string BackgroundColor { get; set; }
    }
}