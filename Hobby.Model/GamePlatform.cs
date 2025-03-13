namespace Games.Model;

public class GamePlatform : BaseModel
{
    public Game? Game { get; set; }
    public Platform? Plataform { get; set; }
}