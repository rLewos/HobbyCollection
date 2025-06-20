using System.Text.Json;
using HobbyCollection.Website.Models.DTO;

namespace HobbyCollection.Website.Service;

public class PlatformService : BaseService<PlatformDto>, IPlatformService
{
    private string _baseEndPoint = "Platform/";
    
    public PlatformService() : base()
    {
        
    }

    public async Task<PlatformDto> GetById(int id)
    {
        string url = BaseUrl + _baseEndPoint + "GetById" + "/" + id;
        
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