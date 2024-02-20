using Microsoft.EntityFrameworkCore.Diagnostics;
using WebApplicationGym.Models.Gym;

namespace WebApplicationGym.Services.Interfaces
{
    public interface IDietGymServices
    {
        public int Save(DietGym dietGym);
        List<DietGym> GetAll();
        DietGym Get(Guid Id);
        Guid Delete(Guid Id);
        
    }
}
