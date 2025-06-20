using System.Text.Json;
using HobbyCollection.Website.Models.DTO;

namespace HobbyCollection.Website.Service;

public class PlataformService : BaseService<PlatformDto>, IPlataformService
{
    private string _baseEndPoint = "Plataform";
    
    public PlataformService() : base()
    {
        
    }

    public async Task<PlatformDto> GetById(int id)
    {
        string url = BaseUrl + _baseEndPoint + "/" + id;
        
        using (var client = new HttpClient())
        {
            try
            {
                var responseMessage = await client.GetAsync(url);
                responseMessage.EnsureSuccessStatusCode();

                string content = await responseMessage.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<PlatformDto>(content);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        return null;
    }

    public Task<List<PlatformDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task Add(PlatformDto item)
    {
        throw new NotImplementedException();
    }
}