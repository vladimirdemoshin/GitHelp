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
                        var commitModel = new Commit
                        {
                            Sha = commit.Sha,
                            Message = commit.Message,
                            Author = _mapSignature(commit.Author),
                            Committer = _mapSignature(commit.Committer)
                        };
                        commits.Add(commitModel);
                    }

                    var branchModel = new Branch 
                    {
                        Name = branch.FriendlyName,
                        Commits = commits,
                        IsRemote = branch.IsRemote
                    };
                    localBranches.Add(branchModel);
                }

                var repository = new Repository(localBranches);

                return repository;
            } 
        }


        public Signature _mapSignature(LibGit2Sharp.Signature signature)
        {
            if (signature == null)
            {
                return null;
            }

            var signatureModel = new Signature
            {
                Name = signature.Name,
                When = signature.When,
            };
            return signatureModel;
        }
    }
}
