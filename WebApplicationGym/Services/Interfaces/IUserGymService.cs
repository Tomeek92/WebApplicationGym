using WebApplicationGym.Models.Gym;

namespace WebApplicationGym.Services.Interfaces
{
    public interface IUserGymService
    {
      public int Save(UserGym user);
      List<UserGym> GetAll();
    }
}
