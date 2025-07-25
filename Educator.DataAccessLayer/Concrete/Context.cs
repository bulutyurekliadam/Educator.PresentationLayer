﻿using Educator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educator.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
	{ 
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-H67U406; initial catalog =DbEdukator; integrated security = true; ");

		}
		public DbSet<Course> Courses{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public  DbSet<Contactinfo>Contactinfos { get; set; }
		public DbSet <Contact> Contacts { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<AboutGrid> AboutGrids{ get; set; }
        public DbSet<MailSubscribe> MailSubscribes{ get; set; }

        public DbSet<CourseRegister> CourseRegisters{ get; set; }

    }
}
