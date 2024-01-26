using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AllForOneControllers.Services.Third;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AllForOneControllers.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class CompareController : Controller
    {
        
    private readonly IThirdService _thirdService;

    public CompareController(IThirdService thirdService)
       {
        _thirdService = thirdService;
    }

        [HttpGet]
        [Route("NumCompare/{numOneString}/{numTwoString}")]

        public string NumCompare(string numOneString, string numTwoString)
        {
            return _thirdService.CompareNums(numOneString, numTwoString);
        }
}
