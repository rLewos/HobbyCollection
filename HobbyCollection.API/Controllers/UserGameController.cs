using AutoMapper;
using Games.Model;
using Games.Service.Interfaces;
using Hobby.Model.DTO;
using Hobby.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.API.Controllers;

[Authorize(Roles = "Manager,REGULAR")]
public class UserGameController(IUserService userService, IGameService gameService, IUserGameService userGameService, IMapper mapper)
    : BaseController
{
    [HttpPost("Save")]
    public IActionResult Save([FromBody] UserGameDTO userGameDto)
    {
        try
        {
            var idUser = Convert.ToInt32(User?.FindFirst("UserId")?.Value);
            var userGame = mapper.Map<UserGame>(userGameDto);

            userGameService.Save(idUser, userGame);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500);
        }
        
        return Ok();
    }

    [HttpDelete("Delete/{gameId}")]
    public IActionResult Delete(int gameId)
    {
        var userId = Convert.ToInt32(User?.FindFirst("UserId")?.Value);
        userGameService.Remove(userId, gameId);
        return Ok();
    }
}