namespace AllForOneControllers.Services.ChallengeSevenInt;

public class ChallengeSevenIntService : IChallengeSevenIntService
{
    public string IntReverse(string numOne)
    {
        int NumInt;
            bool isNumOne = int.TryParse(numOne, out NumInt);

            if(isNumOne){
             string reversed = "";
            for(int i = numOne.Length-1; i >= 0; i--)
            {
            reversed += numOne[i];
            };
            return $"your number was {numOne} and reversed is {reversed}";
            }else{
            return $"Please use a number";
            }
    }
}
