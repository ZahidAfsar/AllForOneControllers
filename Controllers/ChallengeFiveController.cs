using AllForOneControllers.Services.ChallengeFive;
using Microsoft.AspNetCore.Mvc;


namespace AfsarZMiniChallenge5to7.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class ChallengeFiveController : ControllerBase
    {
    private readonly IChallengeFiveService _challengeFiveService;

    public ChallengeFiveController(IChallengeFiveService challengeFiveService)
        {
        _challengeFiveService = challengeFiveService;
    }

        [HttpGet]
        [Route("MadLib/{name}/{username}/{verb}/{nameTwo}/{noun}/{nounTwo}/{verbTwo}/{nounThree}/{nounFour}/{creatureName}/{weaponName}")]

        public string MadLib(string name, string username, string verb, string nameTwo, string noun, string nounTwo, string verbTwo, string nounThree, string nounFour, string creatureName, string weaponName)
        {
            return _challengeFiveService.MadLib(name, username, verb, nameTwo, noun, nounTwo, verbTwo, nounThree, nounFour, creatureName, weaponName);
        }
    }
