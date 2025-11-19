using ÖvningarMockning.Data.Interfaces;

namespace ÖvningarMockning.Core.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public bool IsAdmin(string userId)
        {
            var role = _userRepo.GetRole(userId);
            return role == "Admin";
        }
    }
}
