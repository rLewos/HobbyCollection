using Games.Infraestructure;
using Games.Model;
using Hobby.Repository.Interfaces;

namespace Hobby.Repository;

public class UserGameRepository : IUserGameRepository
{
    private readonly HobbyContext _context;
    
    public UserGameRepository(HobbyContext context)
    {
        _context = context;
    }
    
    public void Save(UserGame entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(UserGame? entity)
    {
        throw new NotImplementedException();
    }

    public UserGame? Get(int id)
    {
        throw new NotImplementedException();
    }
}