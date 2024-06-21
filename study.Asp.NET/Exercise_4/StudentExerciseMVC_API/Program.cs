var builder = WebApplication.CreateBuilder(args);

// Add logging configuration
builder.Logging.ClearProviders(); // Clear default providers (optional)
builder.Logging.AddConsole(); // Add console logger


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseResponseCompression();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.Use(async (context, next) =>
{
    if (context.Request.IsHttps)
    {
        await next();
    }
    else
    {
        var httpsPort = 443; // Change this to the appropriate HTTPS port
        var httpsUrl = $"https://{context.Request.Host.Value}:{httpsPort}{context.Request.PathBase}{context.Request.Path}{context.Request.QueryString}";
        context.Response.Redirect(httpsUrl);
    }
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
