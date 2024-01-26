using AllForOneControllers.Services.ChallengeSevenInt;
using Microsoft.AspNetCore.Mvc;


namespace AfsarZMiniChallenge5to7.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class ChallengeSevenIntController : ControllerBase
    {
    private readonly IChallengeSevenIntService _challengeSevenIntService;

    public ChallengeSevenIntController(IChallengeSevenIntService challengeSevenIntService)
        {
        _challengeSevenIntService = challengeSevenIntService;
    }

        [HttpGet]
        [Route("IntReverse/{numOne}")]

        public string IntReverse(string numOne)
        {
           return _challengeSevenIntService.IntReverse(numOne);
        }
    }