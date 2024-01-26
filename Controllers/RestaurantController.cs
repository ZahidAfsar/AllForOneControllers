using AllForOneControllers.Services.Restaurant;
using Microsoft.AspNetCore.Mvc;


namespace AfsarZMiniChallenge8to10.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    {
    private readonly IRestaurantPickerService _restaurantPickerService;

    public RestaurantController(IRestaurantPickerService restaurantPickerService)
       {
        _restaurantPickerService = restaurantPickerService;
    }

        [HttpGet]
        [Route("fastfoodORpizzaORmexican/{choice}")]
        public string RestaurantPicker(string choice){
            return _restaurantPickerService.RestaurantPicker(choice);
        }
    }
