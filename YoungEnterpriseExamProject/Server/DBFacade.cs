using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using YoungEnterpriseExamProject.Server.EF;

namespace YoungEnterpriseExamProject.Server
{
    public class DBFacade : IDataFacade
    {
        public bool AddPerson(string firstName, string lastName, string mail, string eventStatus, string teamName)
        {
            throw new NotImplementedException();
        }

        public bool AddTeam(string teamName, string track, string school, bool participating)
        {
            throw new NotImplementedException();
        }

        public bool DeletePerson(int personId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTeam(string name)
        {
            throw new NotImplementedException();
        }

        public Person[] GetPersons(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public Team GetTeam(string teamName)
        {
            throw new NotImplementedException();
        }

        public Person[] GetTeamMembers(string teamName)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePerson(int personId, string firstname, string lastName, string mail, string eventStatus, string teamName)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTeam(string oldName, string newName, string track, string school, bool participating)
        {
            throw new NotImplementedException();
        }
    }
}
