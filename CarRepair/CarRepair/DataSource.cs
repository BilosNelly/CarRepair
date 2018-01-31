using System;
using System.IO;
using SQLite;
using System.Collections.Generic;

namespace CarRepair
{
	public class DataSource
	{
		private string databasePath;
		private SQLiteConnection db;

		public DataSource()
		{
			this.databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Database.sqlite");
			File.Delete(databasePath);
			this.db = new SQLiteConnection(databasePath);

			this.db.CreateTable<Employee>();
			this.db.CreateTable<WorkLog>();
			this.db.CreateTable<RepairLog>();
			this.Prepopulate();
		}

		public SQLiteConnection getConnection()
		{
			return this.db;
		}

		public List<Employee> getEmployees()
		{
			return getConnection().CreateCommand("SELECT * FROM Employee").ExecuteQuery<Employee>();
		}

		public Employee getEmployeeByFullName(string fullName)
		{
			var firstName = fullName.Split(' ')[0];
			var lastName = fullName.Split(' ')[1];
			return getConnection().Table<Employee>().Where(v => v.FirstName.Equals(firstName) && v.LastName.Equals(lastName)).FirstOrDefault();
		}

		public Employee getEmployeeById(int id)
		{
			return getConnection().Table<Employee>().Where(v => v.Id == id).First();
		}

		public void addEmployee(string firstName, string lastName, string oib, string username, string password, string startDate, string birthDate, bool isAdmin)
		{
			var employee = new Employee();
			employee.FirstName = firstName;
			employee.LastName = lastName;
			employee.Oib = oib;
			employee.Username = username;
			employee.Password = password;
			employee.Admin = isAdmin;
			getConnection().Insert(employee);
		}

		public void deleteUserByFullName(string fullName)
		{
			var firstName = fullName.Split(' ')[0];
			var lastName = fullName.Split(' ')[1];
			var employee = getConnection().Table<Employee>().Where(v => v.FirstName.Equals(firstName) && v.LastName.Equals(lastName)).FirstOrDefault();
			if (employee != null)
			{
				getConnection().Delete(employee);	
			}
		}

		public void updateEmployee(Employee employee)
		{
			getConnection().Update(employee);
		}

		private void Prepopulate()
		{
			this.db.Insert(new Employee()
			{
				Id = 1,
				FirstName = "Anotonela",
				LastName = "Bilos",
				Username = "abilos",
				Password = "password",
				Admin = true
			});

			this.db.Insert(new Employee()
				{
					Id = 2,
					FirstName = "Tomislava",
					LastName = "Kolar",
					Username = "tkolar",
					Password = "password",
					Admin = true
				});
			
			this.db.Insert (new RepairLog () {
				Registration = "PU-123-AB",
				VehicleType = "Mercedes G",
				VehicleOwner = "Pero Peric",
				WorkDescription = "Pusta mu voda.",
				ReceivedDate = new DateTime(2017, 12, 15),
			});

			this.db.Insert (new RepairLog () {
				Registration = "PU-321-DT",
				VehicleType = "Mazda 6",
				VehicleOwner = "Ivan Ivic",
				WorkDescription = "Popravak amortizera.",
				ReceivedDate = new DateTime(2018, 1, 5),
				Price = 750.00m
			});

			this.db.Insert (new RepairLog () {
				Registration = "PU-456-PP",
				VehicleType = "Audi A6",
				VehicleOwner = "Jadro Jadrankic",
				WorkDescription = "Promijena guma. Stavljene zimske.",
				ReceivedDate = new DateTime(2018, 1, 5),
				Price = 1500.00m,
				Finished = true,
				FinishedDate = new DateTime(2018, 1, 6),
				EmployeeId = 1
			});

			this.db.Insert (new RepairLog () {
				Registration = "PU-684-PP",
				VehicleType = "Kia Pro Ceed",
				VehicleOwner = "Mirna Miric",
				WorkDescription = "Promijena branika.",
				ReceivedDate = new DateTime(2018, 1, 5),
				Price = 3000.00m,
				Finished = true,
				FinishedDate = new DateTime(2018, 1, 6),
				EmployeeId = 2
			});
		}
	}
}
