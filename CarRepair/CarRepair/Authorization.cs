using System;

namespace CarRepair
{
	public class Authorization
	{
		private DataSource dataSource;

		public Authorization(DataSource dataSource)
		{
			this.dataSource = dataSource;
		}

		public Employee Authorize(string username, string password)
		{
			var query = this.dataSource.getConnection().Table<Employee>().Where(v => v.Username.Equals(username) && v.Password.Equals(password));
			return query.FirstOrDefault();
		}
	}
}