using Microsoft.EntityFrameworkCore;
using PersonalBlog.Context;

namespace PersonalBlog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            #region Manually What's Happen with depenedency injection behind the scene
            //DbContextOptions<ApplicationDbContext> options =
            //    new DbContextOptions<ApplicationDbContext>();
            //options.UseSqlServer(); 
            //ApplicationDbContext dbContext = new ApplicationDbContext(options);
            #endregion



            builder.Services.AddDbContext<ApplicationDbContext>
                (ops => ops.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn")));

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
        }
    }
}
