using RazorPageDemo.Models;
using System;
using System.Collections.Generic;

namespace RazorPageDemo.Services
{
	public interface IEmployeeRepository
	{
		IEnumerable<Employee> GetAllEmployees();

		Employee GetEmployee(int id);
	}
}
