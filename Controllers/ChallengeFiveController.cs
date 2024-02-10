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
        [Route("MadLib/{nameOfOcean}/{diverName}/{underwaterRuinName}/{nameOfWorld}/{whatIsLandInhabitedBy}/{whatIsLandInhabitedByTwo}/{howDoYouBeAHero}/ {whatDoYouHate}/{whatDoYouLike}/{whatMonsterAttackedYou}/{weaponUsed}")]

        public string MadLib(string nameOfOcean, string diverName, string underwaterRuinName, string nameOfWorld, string whatIsLandInhabitedBy, string whatIsLandInhabitedByTwo, string howDoYouBeAHero, string whatDoYouHate, string whatDoYouLike, string whatMonsterAttackedYou, string weaponUsed)
        {
            return _challengeFiveService.MadLib(nameOfOcean, diverName, underwaterRuinName, nameOfWorld, whatIsLandInhabitedBy, whatIsLandInhabitedByTwo, howDoYouBeAHero, whatDoYouHate, whatDoYouLike, whatMonsterAttackedYou, weaponUsed);
        }
    }
