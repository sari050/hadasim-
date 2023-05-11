using Microsoft.EntityFrameworkCore;
using Project.Repository.Entities;
using Project.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Context
{
    public class MyDBContext : DbContext, IContext
    {
       public DbSet<PersonalDetails> personalDetailss { get; set; }
       public DbSet<CoronaDetails> coronaDetailss { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ProjectDBName; Trusted_Connection=True");
        }
    }
}