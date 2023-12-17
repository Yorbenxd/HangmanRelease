using Hangman.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hangman
{
    public class UserDataContext:DbContext
    {

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlite("Data Source = DataFile.db");
		}

        public DbSet<User> Users { get; set; }
		public DbSet<Score> Scores { get; set; }

    }
}
