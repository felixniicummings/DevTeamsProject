using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DevTeamRepo
    {
        //private readonly DeveloperRepo _developerRepo = new DeveloperRepo(); // this gives you access to the _developerDirectory so you can access existing Developers and add them to a team
        //DeveloperRepo someRepoInst = new DeveloperRepo();
        //someRepoInst.


        private readonly List<DevTeam> _devTeams = new List<DevTeam>();

        //DevTeam Create
        public void AddTeam(DevTeam team)
        {
            _devTeams.Add(team);

            DeveloperRepo myDevRepo = new DeveloperRepo();
            myDevRepo.GetDeveloperById(2);
        }

        //DevTeam Read
        public List<DevTeam> GetDevTeams()
        {
            return _devTeams;
        }

        //DevTeam Update
        public void UpdateExistingTeam(int originalid, DevTeam newteaminfo) // come back to the update
        {
            // Find the team
        }

        //DevTeam Delete
        public bool RemoveTeamFromList(int id)
        {
            DevTeam team = GetDevTeamById(id);
            if (team == null)
            {
                return false;
            }

            int initialCount = _devTeams.Count;
            _devTeams.Remove(team);

            if (initialCount > _devTeams.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //DevTeam Helper (Get Team by ID)
        public DevTeam GetDevTeamById(int id)
        {
            foreach (DevTeam team in _devTeams)
            {
                if (team.Id == id)
                {
                    return team;
                }
            }
            return null;
        }

        // Get all Developers without Pluralsight Access

    }
}
