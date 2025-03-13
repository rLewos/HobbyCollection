using Games.Model;
using Games.Repository.Interfaces;

namespace Hobby.Repository.Interfaces;

public interface IUserGameRepository : IBaseRepository<UserGame>
{
    UserGame? GetById(int gameId, int userId);
}