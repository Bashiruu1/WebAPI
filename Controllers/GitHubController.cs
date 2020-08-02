﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Security.Permissions;
using System.Text.Json;
using System.Threading.Tasks;
using WebApi.Models;
using WebAPI.Services.GitHubService;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/GitHubApi")]
    public class GitHubController : Controller
    {
        private readonly IGitHubService GitHubService;

        public GitHubController(IGitHubService _GitHubService)
        {
            GitHubService = _GitHubService;
        }

        [HttpGet("/Bashiruu1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces(MediaTypeNames.Application.Json)]  
        public async Task<ActionResult<List<GitRepositoryModel>>> GetRepositories()
        {

            List<GitRepositoryModel> GitRepos = await GitHubService.GetReprositories();
            return GitRepos;
        }

        [HttpPost("/PostGitRepo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<List<GitRepositoryModel>>> GetPersonModel([FromBody] GitRepositoryModel GitRepo)
        {
            List<GitRepositoryModel> GitRepos = await GitHubService.GetReprositories();
            if (!Request.Headers.ContainsKey("Content-Type")) {
                return StatusCode(StatusCodes.Status415UnsupportedMediaType, new GitRepositoryModel { 
                    Name = "415",
                    Description = "Content-Type Not Supported Bro",
                    Html_Url = "Please change it bro"
                });
            }
            var what = Newtonsoft.Json.JsonConvert.SerializeObject(GitRepos);
            return GitRepos;
        }
    }
}
