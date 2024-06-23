var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();//1

var app = builder.Build();

app.UseRouting(); //2

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); //3

app.Run();

//��lem ad�mlar� 
/*
 
 A�a��daki eklentiler yap�larak bir mvc projesi eklenir 
 1)builder.Services.AddControllersWithViews();
 2)app.UseRouting(); 
 3)app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

 */