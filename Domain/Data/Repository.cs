using System.Collections.Generic;

namespace Domain.Data
{
    public class Repository
    {
        public IEnumerable<Branch> LocalBranches { get; protected set; }
        public IEnumerable<Repository> RemoteRepositories { get; protected set; }

        public Repository()
        {

        }
        public Repository(IEnumerable<Branch> localBranches)
        {
            LocalBranches = localBranches;
        }
    }
}
