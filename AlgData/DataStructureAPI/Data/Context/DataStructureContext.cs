﻿namespace DataStructureAPI.Controllers.Data.Context
{
    public class DataStructureContext : DbContext
    {
        public DataStructureContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BaseEntity> BaseEntities { get; set; }
    }
}
