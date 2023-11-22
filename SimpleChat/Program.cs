using SimpleChat.Hubs;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddRazorPages();
        builder.Services.AddSignalR();

        var app = builder.Build();


        app.UseStaticFiles();
        app.MapRazorPages();

        app.MapHub<SimpleChart>("/simplechat");

        //app.MapGet("/", () => "Hello World!");


        app.Run();
    }
}