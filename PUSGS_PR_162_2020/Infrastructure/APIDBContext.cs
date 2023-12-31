﻿using Microsoft.EntityFrameworkCore;
using PUSGS_PR_162_2020.Config;
using PUSGS_PR_162_2020.Models;

namespace PUSGS_PR_162_2020.Infrastructure
{
    public class APIDBContext : DbContext
    {

        // Creating tables in the database through migrations
        public DbSet<User> Users { get; set; }  
        public DbSet<Order> Orders { get; set; }
        public DbSet<Article> Articles { get; set; }

        //Ask from program.cs to provide options to connect to the database (the connection string etc..)
        public APIDBContext(DbContextOptions options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new ArticleConfig());
        }
    }
}
