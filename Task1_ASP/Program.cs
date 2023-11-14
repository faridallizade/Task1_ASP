namespace Task1_ASP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            builder.Services.AddControllersWithViews();
             
            app.MapControllerRoute(
                name: "Zade",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );



            app.Run();
        }
    }
}