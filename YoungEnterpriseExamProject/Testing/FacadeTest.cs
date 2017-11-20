using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungEnterpriseExamProject.Testing
{
    public class FacadeTest
    {
        public void TestReleaseOne()
        {
            if (TestAddPerson())
            {
                Console.WriteLine("Adding persons tests passed!");
            }
            else
            {
                Console.WriteLine("Adding persons tests failed!");
            }

            if (TestGetPersons())
            {
                Console.WriteLine("Getting persons tests passed!");
            }
            else
            {
                Console.WriteLine("Getting persons tests failed!");
            }

            if (TestAddTeam())
            {
                Console.WriteLine("Adding teams tests passed!");
            }
            else
            {
                Console.WriteLine("Adding teams tests failed!");
            }

            if (TestUpdatePerson())
            {
                Console.WriteLine("Updating persons tests passed!");
            }
            else
            {
                Console.WriteLine("Updating persons tests failed!");
            }

            if (TestGetTeamMembers())
            {
                Console.WriteLine("Get persons in a team tests passed!");
            }
            else
            {
                Console.WriteLine("Get persons in a team tests failed!");
            }

            if (TestDeletePerson())
            {
                Console.WriteLine("Delete persons tests passed!");
            }
            else
            {
                Console.WriteLine("Delete persons tests failed!");
            }

            if (TestUpdateTeam())
            {
                Console.WriteLine("Update teams tests passed!");
            }
            else
            {
                Console.WriteLine("Update teams tests failed!");
            }

            if (TestGetTeam())
            {
                Console.WriteLine("Get teams tests passed!");
            }
            else
            {
                Console.WriteLine("Get teams tests failed!");
            }

            if (TestDeleteTeam())
            {
                Console.WriteLine("Delete teams tests passed!");
            }
            else
            {
                Console.WriteLine("Delete teams tests failed!");
            }

            Console.Read();
        }

        public void TestReleaseTwo()
        {

        }

        private bool TestAddPerson()
        {
            Server.IDataFacade facade = new Server.DBFacade();

            string firstName = "Mads";
            string lastName = "Peter";
            string mail = "nothing@this.com";
            string eventStatus = null;

            if (facade.AddPerson(firstName, lastName, mail, eventStatus, null))
            {
                Console.WriteLine("Person added! - Test passed");
            }
            else
            {
                Console.WriteLine("Could not add person! - Test failed");
                return false;
            }

            firstName = "Jens";
            lastName = "Hansen";
            mail = "why@fish.com";
            eventStatus = null;

            if (facade.AddPerson(firstName, lastName, mail, eventStatus, null))
            {
                Console.WriteLine("Person added! - Test passed");
            }
            else
            {
                Console.WriteLine("Could not add person! - Test failed");
                return false;
            }

            mail = "random24@gmail.com";

            if (facade.AddPerson(firstName, lastName, mail, eventStatus, null))
            {
                Console.WriteLine("Person added! - Test passed");
            }
            else
            {
                Console.WriteLine("Could not add person! - Test failed");
                return false;
            }

            return true;
        }

        private bool TestGetPersons()
        {
            Server.IDataFacade facade = new Server.DBFacade();

            string firstName = "Mads";
            string lastName = "Peter";

            Server.EF.Person[] persons = facade.GetPersons(firstName, lastName);

            if (persons != null && persons.Length == 1)
            {
                foreach (var item in persons)
                {
                    if (item.FirstName.Equals(firstName) && item.LastName.Equals(lastName))
                    {
                        Console.WriteLine("This person exits! - Test passed");
                    }
                    else
                    {
                        Console.WriteLine("This person does not exist! - Test failed");
                        return false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Could not find person(s)! - Test failed");
                return false;
            }

            firstName = "Jens";
            lastName = "Hansen";

            persons = facade.GetPersons(firstName, lastName);

            if (persons != null && persons.Length == 2)
            {
                foreach (var item in persons)
                {
                    if (item.FirstName.Equals(firstName) && item.LastName.Equals(lastName))
                    {
                        Console.WriteLine("This person exits! - Test passed");
                    }
                    else
                    {
                        Console.WriteLine("This person does not exist! - Test failed");
                        return false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Could not find person(s)! - Test failed");
                return false;
            }

            return true;
        }

        private bool TestUpdatePerson()
        {
            Server.IDataFacade facade = new Server.DBFacade();

            string firstName = "Ben";
            string lastName = "Hansen";
            string mail = "why@fish.com";
            string eventStatus = "Judge";

            string teamName = "Random";

            if (facade.UpdatePerson(2, firstName, lastName, mail, eventStatus, null))
            {
                Console.WriteLine("Person updated! - Test passed");
            }
            else
            {
                Console.WriteLine("Could not update! - Test failed");
                return false;
            }

            if (facade.UpdatePerson(1, null, null, null, null, teamName))
            {
                Console.WriteLine("Person updated! - Test passed");
            }
            else
            {
                Console.WriteLine("Could not update! - Test failed");
                return false;
            }

            if (facade.UpdatePerson(2, null, null, null, null, teamName))
            {
                Console.WriteLine("Person updated! - Test passed");
            }
            else
            {
                Console.WriteLine("Could not update! - Test failed");
                return false;
            }

            if (facade.UpdatePerson(3, null, null, null, null, teamName))
            {
                Console.WriteLine("Person updated! - Test passed");
            }
            else
            {
                Console.WriteLine("Could not update! - Test failed");
                return false;
            }

            if (!facade.UpdatePerson(4, null, null, null, null, teamName))
            {
                Console.WriteLine("Could not update! - Test passed");
            }
            else
            {
                Console.WriteLine("Person updated! - Test failed");
                return false;
            }

            return true;
        }

        private bool TestAddTeam()
        {
            Server.IDataFacade facade = new Server.DBFacade();

            string teamName = "Random";
            string track = "Trade & Skills";
            string school = null;
            bool participating = true;

            if (facade.AddTeam(teamName, track, school, participating))
            {
                Console.WriteLine("Team created! - Test passed");
            }
            else
            {
                Console.WriteLine("Could not create team! - Test failed");
                return false;
            }

            if (!facade.AddTeam(teamName, track, school, participating))
            {
                Console.WriteLine("Team with this name exists! - Test passed");
            }
            else
            {
                Console.WriteLine("Team created - Test failed");
                return false;
            }

            teamName = "None";
            track = "Trade & Skills";
            school = null;
            participating = true;

            if (facade.AddTeam(teamName, track, school, participating))
            {
                Console.WriteLine("Team created! - Test passed");
            }
            else
            {
                Console.WriteLine("Could not create team! - Test failed");
                return false;
            }

            return true;
        }

        private bool TestGetTeamMembers()
        {
            Server.IDataFacade facade = new Server.DBFacade();

            string teamName = "Random";

            Server.EF.Person[] persons = facade.GetTeamMembers(teamName);

            if (persons != null)
            {
                int i = 0;
                foreach (var item in persons)
                {
                    i++;
                    if (item.PersonId == i)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Wrong person! - Test failed");
                        return false;
                    }
                }
            }
            else
            {
                Console.WriteLine("There are no one in this team! - Test failed");
                return false;
            }

            return true;
        }

        private bool TestDeletePerson()
        {
            Server.IDataFacade facade = new Server.DBFacade();

            if (facade.DeletePerson(3))
            {
                Console.WriteLine("Person removed! - Test passed");
            }
            else
            {
                Console.WriteLine("Could not find person! - Test failed");
                return false;
            }

            if (!facade.DeletePerson(3))
            {
                Console.WriteLine("Could not find person! - Test passed");
            }
            else
            {
                Console.WriteLine("Person removed! - Test failed");
                return false;
            }

            return true;
        }

        private bool TestUpdateTeam()
        {
            Server.IDataFacade facade = new Server.DBFacade();

            string oldTeamName = "None";
            string newTeamName = "Bay";
            string track = "Trade & Skills";
            string school = null;
            bool participating = true;

            if (facade.UpdateTeam(oldTeamName,newTeamName,track,school,participating))
            {
                Console.WriteLine("Team Updated! - Test passed");
            }
            else
            {
                Console.WriteLine("Team not found! - Test failed");
                return false;
            }

            if (!facade.UpdateTeam(oldTeamName, newTeamName, track, school, participating))
            {
                Console.WriteLine("Team not found! - Test passed");
            }
            else
            {
                Console.WriteLine("Team Updated!-Test failed");
                return false;
            }

            return true;
        }

        private bool TestGetTeam()
        {
            Server.IDataFacade facade = new Server.DBFacade();

            string teamName = "Bay";

            Server.EF.Team team = facade.GetTeam(teamName);

            if (team != null && team.TeamName.Equals(teamName))
            {
                Console.WriteLine("Team found! - Test passed");
            }
            else
            {
                Console.WriteLine("Team not found! - Test failed");
                return false;
            }

            teamName = "None";

            team = facade.GetTeam(teamName);

            if (team == null)
            {
                Console.WriteLine("Team not found! - Test passed");
            }
            else
            {
                Console.WriteLine("Team found! - Test failed");
                return false;
            }

            return true;
        }

        private bool TestDeleteTeam()
        {
            Server.IDataFacade facade = new Server.DBFacade();

            string teamName = "Bay";

            if (facade.DeleteTeam(teamName))
            {
                Console.WriteLine("Team deleted! - Test passed");
            }
            else
            {
                Console.WriteLine("Could not find team! - Test failed");
                return false;
            }

            if (!facade.DeleteTeam(teamName))
            {
                Console.WriteLine("Could not find team! - Test passed");
            }
            else
            {
                Console.WriteLine("Team deleted! - Test failed");
                return false;
            }

            teamName = "Random";

            if (facade.DeleteTeam(teamName))
            {
                Console.WriteLine("Team deleted! - Test passed");
            }
            else
            {
                Console.WriteLine("Could not find team! - Test failed");
                return false;
            }

            return true;
        }
    }
}
