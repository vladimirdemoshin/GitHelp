using System.Collections.Generic;

namespace Domain.Core
{
    public class Branch
    {
        public IEnumerable<Commit> Commits { get; protected set; }
    }
}
