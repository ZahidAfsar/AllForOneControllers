using AllForOneControllers.Services.ChallengeSix;
using Microsoft.AspNetCore.Mvc;


namespace AfsarZMiniChallenge5to7.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class ChallengeSixController : ControllerBase
    {
    private readonly IChallengeSixService _challengeSixService;

    public ChallengeSixController(IChallengeSixService challengeSixService)
       {
        _challengeSixService = challengeSixService;
    }

       [HttpGet]
       [Route("ODDorEVEN/{numOne}")]
       
       public string ODDorEVEN (string numOne)
        {
            return _challengeSixService.ODDorEVEN(numOne);
        }
    }
