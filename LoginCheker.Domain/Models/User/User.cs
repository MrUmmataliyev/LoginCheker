using System.ComponentModel.DataAnnotations;

namespace LoginChecker.Domain.Models.User
{
    public class User
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
