using Games.Model;
using Games.Service.Interfaces;
using Hobby.Repository.Interfaces;
using Hobby.Service.Interfaces;

namespace Hobby.Service;

public class UserGameService(IUserGameRepository userGameRepository, IUserService userService, IGameService gameService) : IUserGameService
{
    public void Save(UserGame obj)
    {
        userGameRepository.Save(obj);
    }

    public UserGame? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    public void Save(int userId, UserGame userGame)
    {
        var user = userService.GetById(userId);
        if (user == null)
            throw new Exception("Usuario inexistente");
        
        var game = gameService.GetById(userGame.GameId.Value);
        if (game == null)
            throw new Exception("Game inexistente");

        var newUserGame = new UserGame()
        {
            Game = game,
            User = user,
            GameId = game.Id,
            UserId = user.Id,
            HasBeaten = userGame.HasBeaten,
        };
        
        Save(newUserGame);
    }
}