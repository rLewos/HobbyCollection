using Games.Model;
using Games.Service.Interfaces;

namespace Hobby.Service.Interfaces;

public interface IUserGameService : IBaseService<UserGame>
{
    void Save(int userId, UserGame userGame);
}