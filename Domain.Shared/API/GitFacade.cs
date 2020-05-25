using Domain.API;
using Domain.Configuration;
using Domain.Data;
using System.Collections.Generic;

namespace Domain.Shared.API
{
    public class GitFacade : IGitFacade
    {
        public Repository GetRepository(GitParameters gitParameters)
        {
            return _getTestRepository();
        }

        private Repository _getTestRepository()
        {
            var masterBranch = new Branch("master");
            var devBranch = new Branch("dev");

            var localBranches = new List<Branch> {
                masterBranch,
                devBranch
            };

            var repository = new Repository(localBranches);
            return repository;
        }
    }
}
