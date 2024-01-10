using ChinSMiniChallenge_FivetoSeven.Services.MiniChallenge5;
using Microsoft.AspNetCore.Mvc;

namespace ChinSMiniChallenge_FivetoSeven.Controllers;

[ApiController]
[Route("[controller]")]
    public class MiniCh5Controller : ControllerBase
    {
    private readonly IMiniCh5Service _miniCh5Service;

    public MiniCh5Controller(IMiniCh5Service miniCh5Service)
        {
        _miniCh5Service = miniCh5Service;
    }

        [HttpGet]
        [Route("MadLibs/{userName}/{adj1}/{verb1}/{noun1}/{verb2}/{noun2}/{adj2}/{adj3}/{noun3}/{name2}/{adj4}")]

        public string MadLibs(string userName, string adj1, string verb1, string noun1, string verb2, string noun2, string adj2, string adj3, string noun3, string name2, string adj4)
        {
            return _miniCh5Service.MadLibs(userName, adj1, verb1, noun1, verb2, noun2, adj2, adj3, noun3, name2, adj4);
        } 
    }
