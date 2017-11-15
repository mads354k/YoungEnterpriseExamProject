using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace YoungEnterpriseExamProject.Server.EF
{
    class DataInitializer : DropCreateDatabaseAlways<YoungEnterpriseEntities>
    {
        protected override void Seed(YoungEnterpriseEntities context)
        {
            Console.WriteLine("Seed called");

            context.SaveChanges();
        }
    }
}
