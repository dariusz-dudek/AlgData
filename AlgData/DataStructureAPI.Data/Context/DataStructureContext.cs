namespace DataStructureAPI.Data.Context
{
    public class DataStructureContext : DbContext
    {
        public DataStructureContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<BaseEntity> BaseEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.SeedDatabase();
    }
}
