using ChinSMiniChallenge_FivetoSeven.Services.MiniChallenge7_2;
using Microsoft.AspNetCore.Mvc;

namespace ChinSMiniChallenge_FivetoSeven.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh7NumController
{
    private readonly IMiniCh7_2Service _miniCh7_2Service;

    public MiniCh7NumController(IMiniCh7_2Service miniCh7_2Service)
    {
        _miniCh7_2Service = miniCh7_2Service;
    }

    [HttpGet]
    [Route("ReverseItPt2/{nums1}")]
    public string ReverseItPt2(string nums1)
    {
        return _miniCh7_2Service.ReverseItPt2(nums1);
    }
}
