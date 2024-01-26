namespace AllForOneControllers.Services.SayHello;

public class SayHelloService : ISayHelloService
{
    public string NameReturn(string user)
    {
         return $"Hello, {user}";
    }
}
