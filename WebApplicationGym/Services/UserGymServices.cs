using WebApplicationGym.Models.Gym;
using WebApplicationGym.Services.Interfaces;

namespace WebApplicationGym.Services
{
    public class UserGymServices : IUserGymService
    {
        private readonly WebApplicationGymDbContext _context;
        public UserGymServices(WebApplicationGymDbContext user)
        {
            _context = user;
        }
        public List<UserGym> GetAll()
        {
            var users = _context.userGyms.ToList();
            return users;
        }
        public int Save(UserGym user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return 1;
        }
    }
}
