namespace AllForOneControllers.Services.ChallengeSeven;

public class ChallengeSevenService : IChallengeSevenStringService
{
    public string StringReverse(string wordOne)
    {
       string reversed = "";
        for(int i = wordOne.Length-1; i >= 0; i--)
        {
        reversed += wordOne[i];
        };
        return $"your word was {wordOne} and reversed is {reversed}";
    }
}
