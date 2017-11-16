namespace YoungEnterpriseExamProject.Server.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class YoungEnterpriseEntities : DbContext
    {
        public YoungEnterpriseEntities()
            : base("name=YoungEnterpriseEntities")
        {
            Database.SetInitializer<YoungEnterpriseEntities>(new DropCreateDatabaseAlways<YoungEnterpriseEntities>());
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<QuestionInformation> QuestionInformation { get; set; }
        public virtual DbSet<Questionnarie> Questionnarie { get; set; }
        public virtual DbSet<Team> Team { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.EventStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.TeamName)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.TextDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.Track)
                .IsUnicode(false);

            modelBuilder.Entity<Questionnarie>()
                .Property(e => e.TeamName)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.TeamName)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Track)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.School)
                .IsUnicode(false);
        }
    }
}
