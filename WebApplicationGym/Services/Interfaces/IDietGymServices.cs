using Microsoft.EntityFrameworkCore.Diagnostics;
using WebApplicationGym.Models.Gym;

namespace WebApplicationGym.Services.Interfaces
{
    public interface IDietGymServices
    {
        Guid Save(DietGym diet);
    }
}
