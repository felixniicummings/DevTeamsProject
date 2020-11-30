using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class Developer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool HasPluralsiteAccess { get; set; }

        public Developer() { } //Allows me to instantiate a blank/generic Developer

        public Developer(int id, string name, bool hasPluralsightAccess) //Allow explicit instantiantion/construction
        {
            Id = id;
            Name = name;
            HasPluralsiteAccess = hasPluralsightAccess;
        }
    }
}
