using Microsoft.AspNetCore.Mvc;

namespace ActionResultTypes.Controllers
{
	public class FileResultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public FileResult FileContent()
		{
			//return File("~/Files/BARIS_EMRE_YALCIN-RESUME.pdf", "application/pdf");
			//return File("~/Files/Sample.xlsx", "application/vnd.openxmlformats-officedocument.spreadsheet.sheet");
			//return File("~/Files/Sample.xlsx", "application/vnd.ms-excel");
			return File("~/Files/Sample.xls", "application/vnd.ms-excel");
		}
	}
}
