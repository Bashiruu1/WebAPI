using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Security.Permissions;
using System.Text.Json;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Services.GitHubService;

namespace WebAPI.Controllers
{
    [Route("{version}/github")]
    public class GitHubController : Controller
    {
        private readonly IGitHubService GitHubService;

        public GitHubController(IGitHubService _GitHubService)
        {
            GitHubService = _GitHubService;
        }

        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<PersonModel>> GetCommits([FromQuery] string User)
        {            
            string something = string.Empty;
            PersonModel Person = await GitHubService.GetReprositories(User);

            return Person;
        }
    }
}
