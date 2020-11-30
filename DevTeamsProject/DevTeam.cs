using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DevTeam
    {
        public int Id { get; set; }

        public List<Developer> TeamMembers { get; set; }

        public DevTeam() { }

        /*
        public DevTeam(int id, List<DevTeam> teamMembers)
        {
            Id = id;
            TeamMembers = List<Developer> teamMembers;

        } */
    }
}
