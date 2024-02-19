using WebApplicationGym.Models.Gym;
using WebApplicationGym.Services.Interfaces;

namespace WebApplicationGym.Services
{
    public class DietGymServices : IDietGymServices
    {
        private readonly WebApplicationGymDbContext _context;
        public DietGymServices(WebApplicationGymDbContext context)
        {
            _context = context;
        }
        public List<DietGym> GetAll()
        {
            var dietGym = _context.dietGyms.ToList();
            return dietGym; 
        }
        public int Save(DietGym dietGym)
        {
            _context.Add(dietGym);
            _context.SaveChanges();
            return 1;
        }
    }
}
