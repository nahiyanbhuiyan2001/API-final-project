﻿using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using MyAPI.Models;

namespace MyAPI.Models
{
    public class MyAPIDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public MyAPIDBContext(DbContextOptions<MyAPIDBContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            try
            {

                var connectionString = Configuration.GetConnectionString("soccer");
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }

            catch (Exception)
            {
                Console.Write("bad string");
            }
        }

        public DbSet<SPlayer> Players { get; set; } = null!;
        public DbSet<STeam> Teams { get; set; } = null!;
    }
}
