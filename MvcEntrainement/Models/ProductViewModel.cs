using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntrainement.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public SelectList Family { get; set; }
        public SelectList Delay { get; set; }
        public string ProductFamily { get; set; }
        public string ProductDelay { get; set; }
        public string SearchString { get; set; }
    }
}
