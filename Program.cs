// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace StudentManage
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Program Started");

			try
			{
				using (var context = new StudentContext())
				{
					context.Database.EnsureCreated(); // Creates DB if not exists

					// Add a student if none exist
					if (!context.Students.Any())
					{
						context.Students.Add(new Student { Name = "Zarnab", Age = 25 });
						context.SaveChanges();
						Console.WriteLine("Added a new student to the database.");
					}

					// Fetch and print all students
					var students = context.Students.ToList();
					foreach (var s in students)
					{
						Console.WriteLine($"Student ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}

			Console.WriteLine("Press Enter to exit...");
			Console.ReadLine();
		}
	}
}
