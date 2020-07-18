using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services.GitHubService
{
    public class GitHubService : IGitHubService
    {
        public Task<PersonModel> GetReprositories(string User)
        {
            Random random = new Random();
            PersonModel Person = new PersonModel
            {
                FirstName = User,
                LastName = "Doe",
                Age = random.Next(18, 85)
            };
            return Task.FromResult(Person);
        }
    }
}
