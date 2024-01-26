namespace AllForOneControllers.Services.Guessit;

    public interface IGuessItService
    {
         string Easy(string num);

        string Medium(string num);

        string Hard(string num);
    }
