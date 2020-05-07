using System.Collections.Generic;

namespace Domain.Core
{
    public class Repository
    {
        public IEnumerable<Branch> Branches { get; protected set; }
    }
}
