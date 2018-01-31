using System;
using SQLite;

namespace CarRepair
{
	public class RepairLog
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Registration { get; set; }
		public string VehicleOwner { get; set; }
		public string VehicleType { get; set; }
		public string WorkDescription { get; set; }
		public DateTime ReceivedDate { get; set; }
		public decimal Price { get; set; }
		public int EmployeeId { get; set; }
		public bool Finished { get; set; }
		public DateTime FinishedDate { get; set; }
	}
		
}
