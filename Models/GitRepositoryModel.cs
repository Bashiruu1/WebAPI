using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class GitRepositoryModel
    {
        public string Name { get; set; }
        public string Html_Url { get; set; }
        public string Description { get; set; }
    }
}
