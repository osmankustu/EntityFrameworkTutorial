using EntityFrameworkCore.Data.Context.EntityConfigurations;
using EntityFrameworkCore.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Data.Context
{
    public class ApplicationDbContext : DbContext
    {

        public static string DEFAULT_SCHEMA = "dbo";

        private readonly IConfiguration _configuration;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if is not configured
            if (!optionsBuilder.IsConfigured)
            {
                // make the configurations
                optionsBuilder.UseSqlServer(_configuration["ConnectionString"]);
            }
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Teacher> Teachers {  get; set; }
        public DbSet<Course> Courses { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new StudentEntitiyConfigurations());

            modelBuilder.ApplyConfiguration(new TeacherEntityConfiguration());

            modelBuilder.ApplyConfiguration(new CourseEntityConfiguration());
    
            base.OnModelCreating(modelBuilder);
        }
    }
}
