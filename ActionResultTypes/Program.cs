/* 
 * ACTION KISITLAR
 * 1 - Public olmal�lar
 * 2 - Static olamazlar
 * 3 - Ref ya da out parametre alamazlar
 * 
 * ACTION GER� D�N�� T�PLER�
 * 1 - ViewResult (�u ana kadar yapt���m�z)
 * 2 - PartialViewResult (bunu da g�rd�k)
 * 3 - ContentResult (text ya da html result)
 * 4 - EmptyResult (bo� i�erik d�nebiliriz)
 * 5 - JsonResult
 * 6 - StatusCodeResult (200, 300, 404 vs yani hata kodlar�)
 * 7 - FileResult (jpg, pdf, xls, docx vs)
 * 8 - RedirectToAction (ba�ka bir action'a y�nlendirme)
 * 9 - RedirectResult
 * 10 - JavaScriptResult
 */

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
