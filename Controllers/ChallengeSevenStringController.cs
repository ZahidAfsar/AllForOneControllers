
using AllForOneControllers.Services.ChallengeSeven;
using Microsoft.AspNetCore.Mvc;


namespace AfsarZMiniChallenge5to7.Controllers;

    [ApiController]
    [Route("[controller]")]

    public class ChallengeSevenStringController : ControllerBase
    {
    private readonly IChallengeSevenStringService _challengeSevenStringService;

    public ChallengeSevenStringController(IChallengeSevenStringService challengeSevenStringService)
    {
        _challengeSevenStringService = challengeSevenStringService;
    }

     [HttpGet]
     [Route("StringReverse/{wordOne}")]

     public string StringReverse(string wordOne)
     {
       return _challengeSevenStringService.StringReverse(wordOne);
     }

    }
