using Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<MebelanUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<FirstSlider> FirstSliders { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<AdvertisementPicture> AdvertisementPictures { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<MebelanUser> MebelanUsers { get; set; }
        public DbSet<Store> Stores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }



    }
}
