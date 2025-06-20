using HobbyCollection.Website.Models.DTO;

namespace HobbyCollection.Website.Service;

public interface IBaseService<T> where T : BaseDto
{
    public Task<T> GetById(int id);
    public Task<List<T>> GetAll();
    public Task Add(T item);
}