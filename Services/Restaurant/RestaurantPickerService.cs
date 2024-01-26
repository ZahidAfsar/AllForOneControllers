namespace AllForOneControllers.Services.Restaurant;

    public class RestaurantPickerService : IRestaurantPickerService
    {
    public string[] fastFood = {"McDonalds", "Taco Bell", "Wendys", "Chickfila", "KFC", "Burger King", "In N Out", "Jack in the Box", "Subway", "Five Guys"};

    public string[] pizza = {"Dominos", "Little Ceasars", "Pizza Guys", "Mountain Mikes", "Pizza Hut", "Papa Johns", "Eddies Pizza", "Round Table Pizza", "Papa Murphys", "Costco Pizza"};

    public string[] mexican = {"La Baja", "El Grullense", "Don Rafas", "Don Luis", "El Pazcifico", "Tepa Taqueria", "La Mesa", "Fondita Mexican Restaurant", "Taqueria El Azteca", "Tequileros Taqueria"};

    public Random randomNumber = new();
    public string RestaurantPicker(string food)
    {
        int randomIndex = randomNumber.Next(0, 10);
        string userInput = food.ToLower();
        if(userInput == "fastfood" || userInput == "pizza" || userInput == "mexican"){
            if(userInput == "fastfood"){
                return fastFood[randomIndex];
            } else if (userInput == "pizza"){
                return pizza[randomIndex];
            } else {
                return mexican[randomIndex];
            }
        }else {
            return "Invalid input, please input one of these options: 'fastFood' | 'Pizza' | 'Mexican'";
        }
        
    }

    }
