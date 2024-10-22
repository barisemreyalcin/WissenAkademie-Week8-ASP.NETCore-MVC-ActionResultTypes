/* 
 * ACTION KISITLAR
 * 1 - Public olmalýlar
 * 2 - Static olamazlar
 * 3 - Ref ya da out parametre alamazlar
 * 
 * ACTION GERÝ DÖNÜÞ TÝPLERÝ
 * 1 - ViewResult (þu ana kadar yaptýðýmýz)
 * 2 - PartialViewResult (bunu da gördük)
 * 3 - ContentResult (text ya da html result)
 * 4 - EmptyResult (boþ içerik dönebiliriz)
 * 5 - JsonResult
 * 6 - StatusCodeResult (200, 300, 404 vs yani hata kodlarý)
 * 7 - FileResult (jpg, pdf, xls, docx vs)
 * 8 - RedirectToAction (baþka bir action'a yönlendirme)
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
