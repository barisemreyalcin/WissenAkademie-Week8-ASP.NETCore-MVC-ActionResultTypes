﻿namespace ActionResultTypes.Models
{
	public class Employee
	{
		public int EmployeeID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public Address Address { get; set; }
	}
}
