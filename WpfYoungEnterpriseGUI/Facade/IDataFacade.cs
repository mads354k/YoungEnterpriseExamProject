﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfYoungEnterpriseGUI.Facade
{
    public interface IDataFacade
    {
        bool AddTeam(string teamName, string track, string school, bool participating);
        EF.Team GetTeam(string teamName);
        EF.Person[] GetTeamMembers(string teamName);
        bool UpdateTeam(string oldName, string newName, string track, string school, bool participating);
        bool DeleteTeam(string name);

        bool AddPerson(string firstName, string lastName, string mail, string eventStatus, string teamName);
        EF.Person[] GetPersons(string firstName, string lastName);
        bool UpdatePerson(int personId, string firstname, string lastName, string mail, string eventStatus, string teamName);
        bool DeletePerson(int personId);



        //bool AddAccount(string userName, string password,int personId);
        //EF.Account GetAccount(string userName, string password);
        //bool UpdateAccount(string userName, string password);
        //bool DeleteAccount(string userName);
    }
}
