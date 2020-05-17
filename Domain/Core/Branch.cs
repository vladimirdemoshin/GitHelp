using System.Collections.Generic;

namespace Domain.Core
{
    public class Branch
    {
        public string Name { get; protected set; }
        public IEnumerable<Commit> Commits { get; protected set; }

        public Branch(string name)
        {
            Name = name;
        }
    }
}
