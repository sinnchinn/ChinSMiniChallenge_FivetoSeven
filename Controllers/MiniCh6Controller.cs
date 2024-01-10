using ChinSMiniChallenge_FivetoSeven.Services.MiniChallenge6;
using Microsoft.AspNetCore.Mvc;

namespace ChinSMiniChallenge_FivetoSeven.Controllers;

[ApiController]
[Route("[controller]")]

public class MiniCh6Controller : ControllerBase
{
    private readonly IMiniCh6Service _miniCh6Service;

    public MiniCh6Controller(IMiniCh6Service miniCh6Service)
    {
        _miniCh6Service = miniCh6Service;
    }

    [HttpGet]
    [Route("OddOrEven/{num1}")]

    public string OddOrEven(string num1)
    {
        return _miniCh6Service.OddOrEven(num1);
    }
}
