using Foundation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Foundation.Data;
using Foundation.Areas.Identity.Data;
using System;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("FoundationContextConnection") ?? throw new InvalidOperationException("Connection string 'FoundationContextConnection' not found.");

builder.Services.AddDbContext<FoundationContext>(
    options => options.UseSqlServer(builder.Configuration["Data:Connection"]));

builder.Services.AddDefaultIdentity<FoundationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<FoundationContext>();


// Add services to the container.
builder.Services.AddControllersWithViews();

#region Authorization

AddAuthorizationPolicies(builder.Services);

#endregion

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

void AddAuthorizationPolicies(IServiceCollection services)
{
    services.AddAuthorization(options =>
    {
        options.AddPolicy("authorized_only", policy => policy.RequireClaim("authorized"));
    });
}