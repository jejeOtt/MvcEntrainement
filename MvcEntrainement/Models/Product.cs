using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntrainement.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Family { get; set; }
        public string Category { get; set; }
        public string Range { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        public int Delay { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }

    }
}
