using Microsoft.AspNetCore.Mvc;

namespace ActionResultTypes.Controllers
{
	public class ContentResultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public ContentResult GetContentResult()
		{
			string content = "Hello, ContentResult!";
			return Content(content, "text/plain", System.Text.Encoding.UTF8);
		}

		public ContentResult GetHtmlContentResult()
		{
			string content = "<!DOCTYPE html>" + 
				"<html>" +
				"<head>" +
				"<meta charset='utf-8' />" +
				"<link rel='stylesheet' href='../lib/bootstrap/dist/css/bootstrap.min.css' />" +
				"</head>" +
				"<body>" +
				"<div class='row'>" +
				"<div class='col-sm-8'>" +
				"<div class='card'>" +
				"<div class='card-header'>HTML Content" +
				"</div>" +
				"<div class='card-body'>Content Type HTML" +
				"</div>" +
				"</div>" +
				"</div>" +
				"</div>" +
				"</body>" +
				"</html>";

			ContentResult contentResult = new ContentResult();
			contentResult.Content = content;
			contentResult.ContentType= "text/html";

			return contentResult;
		}

		public EmptyResult GetEmptyResult()
		{
			return new EmptyResult();
		}

		public ContentResult JavaScriptContent()
		{
			return Content("<script type='application/javascript'>alert('Hello, world!')</script>", "text/html");
		}

	}
}

