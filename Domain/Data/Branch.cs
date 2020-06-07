using System;
using System.Collections.Generic;

namespace Domain.Data
{
    public class Branch
    {
        public string Name { get; protected set; }
        public IEnumerable<Commit> Commits { get; protected set; }

        public Guid? Guid { get; set; }

        public Branch(string name, IEnumerable<Commit> commits)
        {
            Name = name;
            Commits = commits;
        }
    }
}
