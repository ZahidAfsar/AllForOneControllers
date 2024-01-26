using AllForOneControllers.Services;
using Microsoft.AspNetCore.Mvc;


namespace AllForOneControllers.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class AddingController : ControllerBase
    {
        private readonly IFirstService _firstService;
    
        public AddingController(IFirstService firstService)
        {   
         _firstService = firstService;
        }

        [HttpGet]
        [Route("NumReturn/{numOne}/{numTwo}")]

        public string NumReturn(string numOne, string numTwo)
        {
            return _firstService.NumReturn(numOne, numTwo);
        }

    }
