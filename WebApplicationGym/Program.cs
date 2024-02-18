using Microsoft.EntityFrameworkCore;
using WebApplicationGym;
using WebApplicationGym.Services;
using WebApplicationGym.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IDietGymServices, DietGymServices>();
builder.Services.AddScoped<IExerciseGymService,ExerciseGymServices>();  
builder.Services.AddScoped<IUserGymService, UserGymServices>();
// Add db Context 
builder.Services.AddDbContext<WebApplicationGymDbContext>(options =>
 options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplicationGym")));


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
