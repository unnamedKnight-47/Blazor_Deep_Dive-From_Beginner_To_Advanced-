namespace ServerManagement.Components.Models;

public class Server
{
    public Server()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 2);
        IsOnline = randomNumber != 0;
    }

    public int ServerId { get; set; }
    public bool IsOnline { get; set; }
    public string? Name { get; set; }
    public string? City { get; set; }
}
