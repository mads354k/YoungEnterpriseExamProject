using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfYoungEnterpriseGUI.Facade;
using WpfYoungEnterpriseGUI.Facade.EF;

namespace WpfYoungEnterpriseGUI.Controller
{
    public class Controller
    {
        private IDataFacade facade;

        public Controller(IDataFacade facade)
        {
            this.facade = facade;
        }

        public Team CreateTeam(string teamName, string track, string school, bool participating)
        {
            Team newTeam = null;

            Team team = facade.GetTeam(teamName);

            if (team != null)
            {
                return null;
            }

            newTeam = new Team {
                TeamName = teamName,
                Track = track,
                School = school,
                Participant = participating
            };

            if (!facade.AddTeam(teamName,track,school,participating))
            {
                return null;
            }

            return newTeam;
        }

        public bool UpdateTeam(string oldName, string newName, string track, string school, bool participating)
        {
            return facade.UpdateTeam(oldName, newName, track, school, participating);
        }

        public bool DeleteTeam(string teamName)
        {
            return facade.DeleteTeam(teamName);
        }

        public Team GetTeamInfo(string teamName)
        {
            Team team = facade.GetTeam(teamName);

            return team;
        }

        public bool RegisterTeam(string teamName)
        {
            Team team = facade.GetTeam(teamName);
            if (team == null || team.Participant == true)
            {
                return false;
            }
            return facade.UpdateTeam(teamName,teamName,null,null,true);
        }

        public bool UploadReport()
        {

            return false;
        }

        public string ReadReport()
        {

            return null;
        }

        public bool RemoveReport()
        {

            return false;
        }

        
    }
}
