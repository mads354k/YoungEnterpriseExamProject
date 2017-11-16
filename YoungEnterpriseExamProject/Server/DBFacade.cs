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
            var context = new EF.YoungEnterpriseEntities();
            Person person = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                Mail = mail,
                EventStatus = eventStatus,
                TeamName = teamName
            };
            context.Person.Add(person);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            
            return true;
        }

        public bool AddTeam(string teamName, string track, string school, bool participating)
        {
            var context = new EF.YoungEnterpriseEntities();

            Team team = new Team
            {
                TeamName = teamName,
                Track = track,
                School = school,
                Participant = participating
            };
            context.Team.Add(team);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
                
            }

            return true;
        }

        public bool DeletePerson(int personId)
        {
            var context = new EF.YoungEnterpriseEntities();
            Person person = context.Person.Find(personId);
            if (person == null)
            {
                return false;
            }
           
            context.Entry(person).State = EntityState.Deleted;

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                 return false;
            }

            return true;
        }

        public bool DeleteTeam(string name)
        {
            var context = new EF.YoungEnterpriseEntities();

            Team team = context.Team.Find(name);

            if(team == null)
            {
                return false;
            }
            //Person[] persons = GetTeamMembers(name);

            //foreach (var item in persons)
            //{
            //    item.TeamName = null;
            //}

            context.Entry(team).State = EntityState.Deleted;

            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
        
            return true;
        }

        public Person[] GetPersons(string firstName, string lastName)
        {
            Person[] persons = null;
            var context = new EF.YoungEnterpriseEntities();

            persons = context.Person.Where(p => p.FirstName.Equals(firstName) && p.LastName.Equals(lastName)).ToArray();

            return persons;
        }

        public Team GetTeam(string teamName)
        {
            Team team = null;

            var context = new EF.YoungEnterpriseEntities();

            team = context.Team.Find(teamName);

            return team;
        }

        public Person[] GetTeamMembers(string teamName)
        {
            Person[] persons = null;

            var context = new EF.YoungEnterpriseEntities();

            persons = context.Person.Where(p => p.TeamName.Equals(teamName)).ToArray();

            return persons;
        }

        public bool UpdatePerson(int personId, string firstname, string lastName, string mail, string eventStatus, string teamName)
        {
            var context = new EF.YoungEnterpriseEntities();

            Person person = context.Person.Find(personId);
            if (person != null)
            {
                if(firstname != null)
                {
                    person.FirstName = firstname;
                }
                if(lastName != null)
                {
                    person.LastName = lastName;
                }
                if(mail != null)
                {
                    person.Mail = mail;
                }
                if(eventStatus != null)
                {
                    person.EventStatus = eventStatus;
                }
                if(teamName != null)
                {
                    person.TeamName = teamName;
                }
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;

                }

                return true;
            }
            else
            {
                return false;
            }          
        }

        public bool UpdateTeam(string oldName, string newName, string track, string school, bool participating)
        {
            using (var context = new EF.YoungEnterpriseEntities())
            {
                Team team = context.Team.Find(oldName);

                if (team == null)
                {
                    return false;
                }

                context.Entry(team).State = EntityState.Deleted;
                try
                {
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    return false;
                }
            }

            using (var context = new EF.YoungEnterpriseEntities())
            {
                Team team = new Team
                {
                    TeamName = newName,
                    Track = track,
                    School = school,
                    Participant = participating
                };

                context.Team.Add(team);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
