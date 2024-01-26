using AllForOneControllers.Services.SayHello;
using Microsoft.AspNetCore.Mvc;


namespace AfsarZAllForOne.Controllers;

   
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
    private readonly ISayHelloService _sayHelloService;

    public SayHelloController(ISayHelloService SayHelloService)
        {
        _sayHelloService = SayHelloService;
    }

        [HttpGet]
        [Route("NameReturn/{user}")]

         public string NameReturn(string user)
        {
            return _sayHelloService.NameReturn(user);
        }
        
    }