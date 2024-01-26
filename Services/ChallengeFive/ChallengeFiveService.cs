namespace AllForOneControllers.Services.ChallengeFive;

public class ChallengeFiveService : IChallengeFiveService
{
    public string MadLib(string nameOfOcean, string diverName, string underwaterRuinName, string nameOfWorld, string whatIsLandInhabitedBy, string whatIsLandInhabitedByTwo, string howDoYouBeAHero, string whatDoYouHate, string whatDoYouLike, string whatMonsterAttackedYou, string weaponUsed)
    {
        return $"Once upon a time in the {nameOfOcean} ocean, there lived a young diver named {diverName}. Who stumbled upon a mysterious {underwaterRuinName} and decided to explore it. Inside they discovered a magical portal that led to {nameOfWorld}. When they entered they saw a land inhabited by {whatIsLandInhabitedBy} and {whatIsLandInhabitedByTwo}. During the first day they become a hero by {howDoYouBeAHero}. Life was great because the old world was filled with {whatDoYouHate} and this new one had {whatDoYouLike}. Until the {whatMonsterAttackedYou} attacked and they had to fight it with a {weaponUsed}. The hero won and lived happily ever after";
    }
}
