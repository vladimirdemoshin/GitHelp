using System;
using System.Collections.Generic;

namespace Domain.Data
{
    public class Branch
    {
        public string Name { get; set; }
        public bool IsRemote { get; set; }
        public IEnumerable<Commit> Commits { get; set; }

        public Guid? Guid { get; set; }
    }
}
