using EFCoreWithAuroMapper.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreWithAuroMapper
{
    public class EFCoreWithAuroMapperContext : DbContext
    {

        public EFCoreWithAuroMapperContext(DbContextOptions<EFCoreWithAuroMapperContext> options) : base(options)
        {

        }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Lecture> Lecture { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<DestinationProfile>(ProfileConfiguration);
        }
    }
}
