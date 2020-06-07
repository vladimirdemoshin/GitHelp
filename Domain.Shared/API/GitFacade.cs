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
            using (var libGitRepository = new LibGit2Sharp.Repository(gitParameters.RepositoryPath))
            {
                var localBranches = new List<Branch>();
                foreach(var branch in libGitRepository.Branches)
                {
                    var commits = new List<Commit>();
                    foreach (var commit in branch.Commits)
                    {
                        var commitModel = new Commit(commit.Message);
                        commits.Add(commitModel);
                    }

                    var branchModel = new Branch(branch.FriendlyName, commits);
                    localBranches.Add(branchModel);
                }

                var repository = new Repository(localBranches);

                return repository;
            } 
        }
    }
}
