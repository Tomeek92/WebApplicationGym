using WebApplicationGym.Models.Gym;

namespace WebApplicationGym.Services.Interfaces
{
    public interface IUserGymService
    {
      public Guid Save(UserGym user);
    }
}
