using AllForOneControllers.Services.Magic8Ball;
using Microsoft.AspNetCore.Mvc;


namespace AfsarZMiniChallenge8to10.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class Magic8Controller : ControllerBase
    {
    private readonly IMagic8BallService _magic8BallService;

    public Magic8Controller(IMagic8BallService magic8BallService)
    {
        _magic8BallService = magic8BallService;
    }

    [HttpGet]
    [Route("YesOrNoQuestion/{Question}")]
    public string EightBall(string Question)
    {
        return _magic8BallService.EightBall(Question);
    }

    }
