﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginChecker.Domain.Models.EmailCheck
{
    public class EmailCheck
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }
    }
}
