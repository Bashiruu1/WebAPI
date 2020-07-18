using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services.GitHubService
{
    public interface IGitHubService
    {
        Task<string> GetReprositories(string User);
    }
}
