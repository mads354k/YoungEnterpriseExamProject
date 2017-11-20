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
            EF.Team team = null;

            return team;
        }

        public bool UpdateTeam(string oldName, string newName, string track, string school, bool participating)
        {

            return true;
        }

        public bool DeleteTeam(string teamName)
        {

            return true;
        }

        public EF.Team GetTeamInfo(string teamName)
        {
            EF.Team team = null;

            return team;
        }

        public bool RegisterTeam(string teamName)
        {

            return true;
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
