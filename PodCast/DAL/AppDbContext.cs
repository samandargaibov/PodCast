﻿using Microsoft.EntityFrameworkCore;
using PodCast.DAL.Entities;

namespace PodCast.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Episode> Episodes { get; set;}
        public DbSet<Speaker> Speakers { get; set;}
        public DbSet<SpeakerTopics> SpeakerTopics { get; set;}
        public DbSet<Topic> Topics { get; set;}
        public DbSet<Header> Headers { get; set;}
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
