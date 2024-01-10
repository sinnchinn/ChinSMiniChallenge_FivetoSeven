using ChinSMiniChallenge_FivetoSeven.Services.MiniChallenge7_1;
using Microsoft.AspNetCore.Mvc;

namespace ChinSMiniChallenge_FivetoSeven.Controllers;

[ApiController]
[Route("[controller]")]
    public class MiniCh7AlphNumController
    {
    private readonly IMiniCh7_1Service _miniCh7_1Service;

    public MiniCh7AlphNumController(IMiniCh7_1Service miniCh7_1Service)
    {
        _miniCh7_1Service = miniCh7_1Service;
    }

        [HttpGet]
        [Route("ReverseItPt1/{userInput}")]

        public string ReverseItPt1(string userInput)
        {
            return _miniCh7_1Service.ReverseItPt1(userInput);
        }
    }
