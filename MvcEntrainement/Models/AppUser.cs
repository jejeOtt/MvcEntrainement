﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcEntrainement.Extensions;

namespace MvcEntrainement.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string Gender { get; set; }
        public string Country { get; set; }
        public ICollection<Product> Products { get; set;}

    //    public int GetAge()
    //    {
    //        return DateOfBirth.CalculateAge();
    //    }
    }
}
