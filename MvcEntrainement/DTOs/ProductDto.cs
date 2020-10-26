using System;
using System.ComponentModel.DataAnnotations;

namespace MvcEntrainement.DTOs
{
    public class ProductDto
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
    }
}