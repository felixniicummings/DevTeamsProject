using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevTeamsProject; // I brought this in manually

namespace DevConsole
{
    class ProgramUI
    {
        private DeveloperRepo _developerRepo = new DeveloperRepo();
        //Method that runs/starts the UI part of the application
        public void Run()
        {
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                // Display our options to the user
                Console.WriteLine("Select a Menu option:\n" +
                        "1. Add New developer\n" +
                        "2. View All Developers\n" +
                        "3. View Developer by ID\n" +
                        "4. Update Develper Information\n" +
                        "5. Delete Existing Devloper" +
                        "6. Exit" +
                        "7. Add a new Team" +
                        "8. Add Members to Team" +
                        "9. Delete Exisginting Team" +
                        "10 ");
                // Get the user's input
                string input = Console.ReadLine();

                //Evaluate user's input and act accordingly
                switch (input)
                {
                    case "1":
                        //Create new Developer
                        CreateNewDevoper();
                        break;
                    case "2":
                        //View all content
                        DisplayAllDevelopers();
                        break;
                    case "3":
                        // View Content By Title
                        DisplayDevelopersByID();
                        break;
                    case "4":
                        // Update Existing Content
                        UpdateExistingDeveloperInfo();
                        break;
                    case "5":
                        // Delete Existing Content
                        DeleteExistingDeveloper();
                        break;
                    case "6":
                        //Exit
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        break;
                    default:
                        // Please
                        Console.WriteLine("Please enter a valid number.");
                        break;

                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Create new Developer
        public void CreateNewDevoper()
        {
            Console.Clear();
            Developer newDeveloper = new Developer();

            //ID
            Console.WriteLine("Enter Developer ID ");
            //newDeveloper.Id = Console.ReadLine();
            //Developer Name
            Console.WriteLine("Enter Developer Name ");
            newDeveloper.Name = Console.ReadLine();
        }

        //View all content

        // View Content By Title
        public void DisplayAllDevelopers()
        {

        }

        // Update Existing Content
        public void DisplayDevelopersByID()
        {

        }


        // Delete Existing Content
        public void DeleteExistingDeveloper()
        {

        }

        //Update Developre info
        public void UpdateExistingDeveloperInfo()
        {

        }



    }
}
