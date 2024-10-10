namespace api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Pagina principal");
        app.MapGet("/produtos", () => "Lista de produtos");

        app.Run();
    }
}
