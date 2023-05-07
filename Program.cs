using BulkyBooksmvc.Data;
using BulkyBooksmvc.Models.Repository;
using BulkyBooksmvc.Models.Service;
using BulkyGenresmvc.Models.Repository;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Internal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IBookRepository, MockBookRepository>();
builder.Services.AddScoped<IGenreRepository, MockGenreRepository>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IGenreService, GenreService>();
builder.Services.AddSession();

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

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
