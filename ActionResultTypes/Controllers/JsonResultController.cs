using ActionResultTypes.Models;
using Microsoft.AspNetCore.Mvc;

namespace ActionResultTypes.Controllers
{
	public class JsonResultController : Controller
	{
		List<Employee> employees = new List<Employee>()
		{
			new Employee() 
			{
				EmployeeID = 1,
				FirstName = "Kelly",
				LastName = "Doe",
				Email = "kellydoe@contoso.com",
				Address = new Address()
				{
					AddressID = 1,
					City = "Los Angeles",
					Country = "USA",
					AddressDetail = "123 Street, LA",
				}
			},

			new Employee()
			{
				EmployeeID = 2,
				FirstName = "Pane",
				LastName = "Doe",
				Email = "panedoe@contoso.com",
				Address = new Address()
				{
					AddressID = 2,
					City = "New York",
					Country = "USA",
					AddressDetail = "312 Street, NY",
				}
			}
		};

		public IActionResult Index()
		{
			return View();
		}

		public JsonResult GetJsonEmployee()
		{
			return Json(employees);
		}
	}
}
