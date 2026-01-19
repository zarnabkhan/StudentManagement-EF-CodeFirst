using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;

namespace StudentManage
{
	public class StudentContext : DbContext
	{
		public DbSet<Student> Students { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// Using LocalDB (no SQL setup needed)
			optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=StudentDB;Trusted_Connection=True;");
		}
	}
}

