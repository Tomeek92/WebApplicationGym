﻿using Microsoft.EntityFrameworkCore;
using WebApplicationGym.Models.Gym;

namespace WebApplicationGym
{
    public class WebApplicationGymDbContext : DbContext
    {
        public WebApplicationGymDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<DietGym> dietGyms { get; set; }   
        public DbSet<ExerciseGym> exerciseGyms { get; set; }
        public DbSet<UserGym>   userGyms { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
