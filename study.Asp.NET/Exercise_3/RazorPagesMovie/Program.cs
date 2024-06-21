using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//changed connection string to use current working directory
//so i can have database file in same directory as the project
builder.Services.AddDbContext<RazorPagesMovieContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("RazorPagesMovieContext");

    options.UseSqlServer(connectionString);
});

//--
var app = builder.Build();

//the using method ensures that the context is disposed
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    //this is adding our SeedData class in Models folder
    SeedData.Initialize(services);
}
//--

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
// Adding Localization for Decimal Validation---------------------------------
// Create a CultureInfo for the Swedish locale
var swedishCulture = new CultureInfo("sv-SE");

// Adjust number formatting for Swedish culture
var numberFormat = new NumberFormatInfo();
numberFormat.NumberDecimalSeparator = ",";
numberFormat.NumberGroupSeparator = ".";
swedishCulture.NumberFormat = numberFormat;

// Configure localization options
var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("en-US"), // English UI culture
    SupportedCultures = new List<CultureInfo> { swedishCulture, CultureInfo.InvariantCulture },
    SupportedUICultures = new List<CultureInfo> { swedishCulture, CultureInfo.InvariantCulture }
};

// Apply the localization options
app.UseRequestLocalization(localizationOptions);
//-----------------------------------------------------------------------------

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
