using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungEnterpriseExamProject.Testing
{
    class UseCaseTest
    {
        public void TestReleaseOne()
        {
            if (TestCreateTeam())
            {
                Console.WriteLine("CreateTeam - Test Passed");
            }
            else
            {
                Console.WriteLine("CreateTeam - Test Failed");
            }

            if (TestChangeMembers())
            {
                Console.WriteLine("ChangeMembers - Test Passed");
            }
            else
            {
                Console.WriteLine("ChangeMembers - Test Failed");
            }

            if (TestChangeTrack())
            {
                Console.WriteLine("ChangeTrack - Test Passed");
            }
            else
            {
                Console.WriteLine("ChangeTrack - Test Failed");
            }

            if (TestChangeTeamName())
            {
                Console.WriteLine("ChangeTeamName - Test Passed");
            }
            else
            {
                Console.WriteLine("ChangeTeamName - Test Failed");
            }

            if (TestUpdateTeam())
            {
                Console.WriteLine("UpdateTeam - Test Passed");
            }
            else
            {
                Console.WriteLine("UpdateTeam - Test Failed");
            }

            if (TestGetTeamInfo())
            {
                Console.WriteLine("GetTeamInfo - Test Passed");
            }
            else
            {
                Console.WriteLine("GetTeamInfo - Test Failed");
            }

            if (TestRegisterTeam())
            {
                Console.WriteLine("RegisterTeam - Test Passed");
            }
            else
            {
                Console.WriteLine("RegisterTeam - Test Failed");
            }

            if (TestSaveTeam())
            {
                Console.WriteLine("SaveTeam - Test Passed");
            }
            else
            {
                Console.WriteLine("SaveTeam - Test Failed");
            }

            if (TestDeleteTeam())
            {
                Console.WriteLine("DeleteTeam - Test Passed");
            }
            else
            {
                Console.WriteLine("DeleteTeam - Test Failed");
            }

            if (TestUploadReport())
            {
                Console.WriteLine("UploadReport - Test Passed");
            }
            else
            {
                Console.WriteLine("UploadReport - Test Failed");
            }

            if (TestReadReport())
            {
                Console.WriteLine("ReadReport - Test Passed");
            }
            else
            {
                Console.WriteLine("ReadReport - Test Failed");
            }

            if (TestRemoveReport())
            {
                Console.WriteLine("RemoveReport - Test Passed");
            }
            else
            {
                Console.WriteLine("RemoveReport - Test Failed");
            }

            Console.Read();
        }

        private bool TestCreateTeam()
        {
            Server.Controller controller = new Server.Controller(new Server.DBFacade());

            Server.EF.Team team = controller.CreateTeam("Random", "Science & Technology", null, false);

            if (team == null || !team.TeamName.Equals("Random"))
            {
                return false;
            }

            team = controller.CreateTeam("None", "Science & Technology", null, false);

            if (team == null || !team.TeamName.Equals("None"))
            {
                return false;
            }

            team = controller.CreateTeam("FishEater", "Science & Technology", null, false);

            if (team == null || !team.TeamName.Equals("FishEater"))
            {
                return false;
            }

            team = controller.CreateTeam("Random", "Science & Technology", null, false);

            if (team != null)
            {
                return false;
            }

            return true;
        }

        private bool TestUpdateTeam()
        {
            Server.Controller controller = new Server.Controller(new Server.DBFacade());

            if (!controller.UpdateTeam("None", "Something", null, null, false))
            {
                return false;
            }

            if (!controller.UpdateTeam("Somthing", "Something", "Society & Globalization", "VUC", false))
            {
                return false;
            }

            if (controller.UpdateTeam("None", "None", null, null, false))
            {
                return false;
            }

            if (!controller.UpdateTeam("Random", "Random", null, null, true))
            {
                return false;
            }

            return true;
        }

        private bool TestDeleteTeam()
        {
            Server.Controller controller = new Server.Controller(new Server.DBFacade());

            if (!controller.DeleteTeam("Random"))
            {
                return false;
            }

            if (controller.DeleteTeam("Random"))
            {
                return false;
            }

            return true;
        }

        private bool TestGetTeamInfo()
        {
            Server.Controller controller = new Server.Controller(new Server.DBFacade());

            Server.EF.Team team = controller.GetTeamInfo("Random");

            if (team == null || !team.TeamName.Equals("Random"))
            {
                return false;
            }

            team = controller.GetTeamInfo("Something");

            if (team == null || !team.TeamName.Equals("Something"))
            {
                return false;
            }

            team = controller.GetTeamInfo("Exist");

            if (team != null)
            {
                return false;
            }

            return true;
        }

        private bool TestRegisterTeam()
        {
            Server.Controller controller = new Server.Controller(new Server.DBFacade());

            if (!controller.RegisterTeam("Random"))
            {
                return false;
            }

            if (controller.RegisterTeam("Random"))
            {
                return false;
            }

            if (controller.RegisterTeam("Exist"))
            {
                return false;
            }

            return true;
        }

        private bool TestUploadReport()
        {
            Server.Controller controller = new Server.Controller(new Server.DBFacade());

            return false;
        }

        private bool TestReadReport()
        {
            Server.Controller controller = new Server.Controller(new Server.DBFacade());

            return false;
        }

        private bool TestRemoveReport()
        {
            Server.Controller controller = new Server.Controller(new Server.DBFacade());

            return false;
        }

        private bool TestChangeMembers()
        {
            Server.Controller controller = new Server.Controller(new Server.DBFacade());

            return false;
        }

        private bool TestChangeTrack()
        {
            Server.Controller controller = new Server.Controller(new Server.DBFacade());

            return false;
        }

        private bool TestChangeTeamName()
        {
            Server.Controller controller = new Server.Controller(new Server.DBFacade());

            return false;
        }

        private bool TestSaveTeam()
        {
            Server.Controller controller = new Server.Controller(new Server.DBFacade());

            return false;
        }
    }
}
