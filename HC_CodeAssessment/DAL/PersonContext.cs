using HC_CodeAssessment.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HC_CodeAssessment.DAL
{
    public class PersonContext : DbContext
    {

        public PersonContext() : base("PersonContext")
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Interest> Interests { get; set; }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}