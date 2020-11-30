using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DeveloperRepo
    {
        private readonly List<Developer> _developerDirectory = new List<Developer>();

        //Developer Create
        public void AddDeveloperToList(Developer developer)
        {
            _developerDirectory.Add(developer);
        }

        //Developer Read
        public List<Developer> GetDevelopers()
        {
            return _developerDirectory;
        }

        //Developer Update
        public bool UpdateExistContent(int originalId, Developer newdevinfo)
        {
            //Find the content
            Developer existingDeveloper = GetDeveloperById(originalId);

            //Update the developer
            if(existingDeveloper != null)
            {
                existingDeveloper.Id = newdevinfo.Id; //***Question: Do I need to update Id
                existingDeveloper.Name = newdevinfo.Name; 
                existingDeveloper.HasPluralsiteAccess = newdevinfo.HasPluralsiteAccess;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Developer Delete
        public bool RemoveDeveloperFromList(int id)
        {
            Developer developer = GetDeveloperById(id);

            if (developer == null)
            {
                return false;
            }

            int initialCount = _developerDirectory.Count;
            _developerDirectory.Remove(developer);

            if (initialCount > _developerDirectory.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Developer Helper (Get Developer by ID)
        public Developer GetDeveloperById(int id)
        {
            foreach (Developer developer in _developerDirectory)
            {
                if(developer.Id == id)
                {
                    return developer;
                }
            }

            return null;
        }
    }
}
