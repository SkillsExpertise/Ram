using RazorPageDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RazorPageDemo.Services
{
	public class MockEmployeeRepository : IEmployeeRepository
	{
		private readonly List<Employee> employees;

		public MockEmployeeRepository()
		{
			employees = new List<Employee>()
			{
				new Employee() { Id =1, Name="Ram" , Department = Dept.IT, Email = "ram.kushwaha@incedoinc.com", PhotoPath= "ram.jpg"},
				new Employee() { Id =2, Name="Vandana" , Department = Dept.HR, Email = "vandana.sharma@incedoinc.com", PhotoPath= "vandana.jpg"},
				new Employee() { Id =3, Name="Arvind" , Department = Dept.Payroll, Email = "arvind.gupta@incedoinc.com", PhotoPath= "arvind.jpg"},
				new Employee() { Id =4, Name="Mohit" , Department = Dept.IT, Email = "mohit.kumar@incedoinc.com"},
			};
		}
		public IEnumerable<Employee> GetAllEmployees()
		{
			return employees;
		}

		public Employee GetEmployee(int id) 
		{
			return employees.FirstOrDefault(e => e.Id == id);
		}
	}
}
