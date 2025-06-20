using HobbyCollection.Website.Models.DTO;

namespace HobbyCollection.Website.Service;

public abstract class BaseService<T> : IBaseService<T> where T : BaseDto
{
    public string BaseUrl
    {
        get
        {
            return "http://localhost:5159/api/";
        }
    }

    public BaseService()
    {
        
    }
    
    public Task<T> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<T>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task Add(T item)
    {
        throw new NotImplementedException();
    }
}