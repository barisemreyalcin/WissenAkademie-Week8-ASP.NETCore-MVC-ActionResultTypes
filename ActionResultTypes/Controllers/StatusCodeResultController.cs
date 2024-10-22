using Microsoft.AspNetCore.Mvc;

namespace ActionResultTypes.Controllers
{
	public class StatusCodeResultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public StatusCodeResult StatusCodeContent() {
			//return Ok();
			// return StatusCode(200); // Aynı yukardakiyle
			//return NotFound();
			//return Unauthorized();
			return BadRequest();
		}
	}
}
