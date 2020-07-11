using CentralDeErros.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Environment = CentralDeErros.API.Models.Environment;

namespace CentralDeErros.API.DataContext
{
    public class CentralDeErrosContext : DbContext
    {
        public DbSet<Occurrence> Occurrences { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Microservice> Microservices { get; set; }
        public DbSet<Environment> Environments { get; set; }

        public CentralDeErrosContext(DbContextOptions<CentralDeErrosContext> options)
           : base(options)
        {
        }
    }
}
