using System;
using SQLite;

namespace CarRepair
{
	public class Employee
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Oib { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public bool Admin { get; set; }
		public DateTime BirthDate { get; set; }
		public DateTime EmploymentDate { get; set; }
	}

	public class WorkLog
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Manufacturer { get; set; }
		public string Registration { get; set; }
		public string OwnerName { get; set; }
		public string WorkDescription { get; set; }
		public DateTime ReceivedAt { get; set; }
		public DateTime FinishedAt { get; set; }
		public int EmployeeId { get; set; }
	}
}
