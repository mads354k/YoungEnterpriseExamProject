using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungEnterpriseExamProject.Server
{
    class Controller
    {
        private IDataFacade facade;

        public Controller(IDataFacade facade)
        {
            this.facade = facade;
        }

        public EF.Team CreateTeam(string teamName, string track, string school, bool participating)
        {
            EF.Team newTeam = null;

            EF.Team team = facade.GetTeam(teamName);

            if (team != null)
            {
                return null;
            }

            newTeam = new EF.Team {
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

        public EF.Team GetTeamInfo(string teamName)
        {
            EF.Team team = facade.GetTeam(teamName);

            return team;
        }

        public bool RegisterTeam(string teamName)
        {
            Server.EF.Team team = facade.GetTeam(teamName);
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

        public bool ChangeTeamMembers(string teamName)
        {

            return false;
        }

        public bool ChangeTrack(string teamName, string track)
        {

            return false;
        }

        public bool ChangeTeamName(string oldName, string newName)
        {

            return false;
        }

        public bool SaveTeam()
        {

            return false;
        }
    }
}
