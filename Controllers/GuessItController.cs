using AllForOneControllers.Services.Guessit;
using Microsoft.AspNetCore.Mvc;


namespace AfsarZMiniChallenge8to10.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
    private readonly IGuessItService _guessItService;

    public GuessItController(IGuessItService guessItService)
    {
        _guessItService = guessItService;
    }

    [HttpGet]
    [Route("Easy/Guess1-10/{numberGuess}")]
    public string Easy(string numberGuess){
        return _guessItService.Easy(numberGuess);
    }

    [HttpGet]
    [Route("Medium/Guess1-50/{numberGuess}")]
    public string Medium(string numberGuess){
        return _guessItService.Medium(numberGuess);
    }

    [HttpGet]
    [Route("Hard/Guess1-100/{numberGuess}")]
    public string Hard(string numberGuess){
        return _guessItService.Hard(numberGuess);
    }

    }
