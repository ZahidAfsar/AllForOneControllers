using AllForOneControllers.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneControllers.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class AskingQuestionController : ControllerBase
    {
       private readonly ISecondService _secondService;

    public AskingQuestionController(ISecondService SecondService)
    {
        _secondService = SecondService;
    }

        [HttpGet]
        [Route("NameReturn/{name}/{time}")]

        public List<string> NameReturn(string name, string time)
        {
            return _secondService.NameReturn(name, time);
        }
    }
    
