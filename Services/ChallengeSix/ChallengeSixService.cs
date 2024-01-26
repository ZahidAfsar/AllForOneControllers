namespace AllForOneControllers.Services.ChallengeSix;

public class ChallengeSixService : IChallengeSixService
{
    public string ODDorEVEN(string numOne)
    {
        int NumInt;
        bool isNumOne = int.TryParse(numOne, out NumInt);

        if(isNumOne){
        if(NumInt % 2 == 0){
            return $"{NumInt} is an even number";
        }else{
            return $"{NumInt} is an odd number";
            }
        }else{
        return $"Please use a number";
       }
    }
}

