using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Wishes> Wishes { get; set; }
        public DbSet<CompanyPosition> CompanyPosition { get; set; }
        public DbSet<HealthControl> HealthControl { get; set; }
        public DbSet<Requests> Requests { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Workers> Workers { get; set; }
        public DbSet<Sickness> Sickness { get; set; }
        public DbSet<Requests> Request { get; set; }
        public DbSet<VacationList> VacationList { get; set; }
        public DbSet<Permitions> Permitions { get; set; }
        public DbSet<Children> Children { get; set; }




    }
}
