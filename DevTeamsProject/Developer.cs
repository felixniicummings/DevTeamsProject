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

        public int HasPluralsiteAccess { get; set; }

        public Developer() { }

        public Developer(int id, string name, int hasPluralsightAccess)
        {
            Id = id;
            Name = name;
            HasPluralsiteAccess = hasPluralsightAccess;
        }
    }
}
