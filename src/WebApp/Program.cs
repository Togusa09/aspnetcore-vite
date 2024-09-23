using Vite.AspNetCore;

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

//app.UseAuthorization();

//app.MapControllerRoute(name: "blog",
//    pattern: "api/{*article}",
//    defaults: new { controller = "Blog", action = "Article" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// If you need to get requests to fallback to the index.html
//app.MapFallbackToFile("index.html");

// Override for specific route ie. /admin
//app.MapFallbackToFile("/admin/{**slug}", "admin/index.html");

// Can also exclude/restrict to paths with UseWhen
//app.UseWhen(ctx => !ctx.Request.Path.StartsWithSegments("api"),
//    appCond =>
//    {
//        appCond.UseEndpoints(routeBuilder => routeBuilder.MapFallbackToFile(""));
//    });

//app.Use(next => context =>
//{
//    if (!context.Request.Host.Host.StartsWith("api", StringComparison.InvariantCultureIgnoreCase))
//    {
//        context.Request.Path = "/Index.html";
//        // Set endpoint to null so the static files middleware will handle the request.
//        context.SetEndpoint(null);
//    }

//    return next(context);
//});

if (app.Environment.IsDevelopment())
{
    app.UseWebSockets();
    // Use Vite Dev Server as middleware.
    app.UseViteDevelopmentServer(true);
}

app.Run();
