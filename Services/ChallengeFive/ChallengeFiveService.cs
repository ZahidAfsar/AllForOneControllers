namespace AllForOneControllers.Services.ChallengeFive;

public class ChallengeFiveService : IChallengeFiveService
{
    public string MadLib(string name, string username, string verb, string nameTwo, string noun, string nounTwo, string verbTwo, string nounThree, string nounFour, string creatureName, string weaponName)
    {
        return $"Once upon a time in the {name} ocean, there lived a young diver named {username}. Who stumbled upon a mysterious {verb} and decided to explore it. Inside they discovered a magical portal that led to {nameTwo}. When they entered they saw a land inhabited by {noun} and {nounTwo}. During the first day they become a hero by {verbTwo}. Life was great because the old world was filled with {nounThree} and this new one had {nounFour}. Until the {creatureName} attacked and they had to fight it with a {weaponName}. The hero won and lived happily ever after";
    }
}
