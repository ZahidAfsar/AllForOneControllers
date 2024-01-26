namespace AllForOneControllers.Services.Guessit;

    public class GuessItService : IGuessItService
    {
          public Random randomNumber = new();
    public string Easy(string num)
    {
        if(int.TryParse(num, out int num2)){
            if(num2 >= 1 && num2 <= 10){
                int realNum = randomNumber.Next(1, 11);
                if(num2 > realNum){
                    return $"Your guess: {num}. Try Guessing Lower!";
                } else if (num2 < realNum){
                    return $"Your guess: {num}. Try Guessing Higher!";
                } else {
                    return $"{num} was the correct answer!";
                }
            } else {
                return "Try to input a number that is 1-10";
            }
        } else {
            return "Invalid Input, try to input a number that is 1-10";
        }
        
    }

    public string Medium(string num)
    {
        if(int.TryParse(num, out int num2)){
            if(num2 >= 1 && num2 <= 50){
                int realNum = randomNumber.Next(1, 51);
                if(num2 > realNum){
                    return $"Your guess: {num}. Try Guessing Lower!";
                } else if (num2 < realNum){
                    return $"Your guess: {num}. Try Guessing Higher!";
                } else {
                    return $"{num} was the correct answer!";
                }
            } else {
                return "Try to input a number that is 1-50";
            }
        } else {
            return "Invalid Input, try to input a number that is 1-50";
        }
    }

    public string Hard(string num)
    {
        if(int.TryParse(num, out int num2)){
            if(num2 >= 1 && num2 <= 100){
                int realNum = randomNumber.Next(1, 101);
                if(num2 > realNum){
                    return $"Your guess: {num}. Try Guessing Lower!";
                } else if (num2 < realNum){
                    return $"Your guess: {num}. Try Guessing Higher!";
                } else {
                    return $"{num} was the correct answer!";
                }
            } else {
                return "Try to input a number that is 1-100";
            }
        } else {
            return "Invalid Input, try to input a number that is 1-100";
        }
    }
    }
