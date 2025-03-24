﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Company.DAL.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string lastgName { get; set; }
        public bool IsAgree { get; set; }
    }
}
