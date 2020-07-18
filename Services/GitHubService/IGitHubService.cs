using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services.GitHubService
{
    public interface IGitHubService
    {
        Task<PersonModel> GetReprositories(string User);
    }
}
