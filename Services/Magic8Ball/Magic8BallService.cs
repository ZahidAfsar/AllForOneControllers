namespace AllForOneControllers.Services.Magic8Ball;

    public class Magic8BallService : IMagic8BallService
    {
        public string EightBall(string magic)
    {
        string[] response = {"No", "Im busy", "NOooooooo", "Ask someone else", "Yes", "Trust yourself", "Yes it is a good idea", "The unanimous Declaration of the thirteen united States of America, When in the Course of human events, it becomes necessary for one people to dissolve the political bands which have connected them with another, and to assume among the powers of the earth, the separate and equal station to which the Laws of Nature and of Nature's God entitle them, a decent respect to the opinions of mankind requires that they should declare the causes which impel them to the separation."};
        Random randomGen = new();
        int randomIndex = randomGen.Next(0, response.Length);
        return response[randomIndex];
    }

    }
