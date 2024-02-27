
using LoginChecker.Domain.Models.User;
using LoginChecker.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace LoginChecker.Application.Service.Registers
{
    public class RegisterService : IRegisterService
    {
        private readonly ApplicationDbContext _context;

        public async Task<bool> DoesExist(string useremail)
        {
            var emails = await _context.Users.ToListAsync();
            foreach (var user in emails)
            {
                if(user.UserEmail == useremail) return true;
            }
            return false;
        }

        public async Task<string> Register(string useremail, string password)
        {
            RegisterService register = new RegisterService();
            if (!register.DoesExist(useremail).Result)
            {
                var User = new User
                {
                    UserEmail = useremail,
                    UserPassword = password
                };
                await _context.Users.AddAsync(User);
                return "Registered";
            }
            return "Email aready exists";
        }
    }
}
