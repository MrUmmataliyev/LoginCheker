using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginChecker.Domain.Models.User
{
    public class User
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
