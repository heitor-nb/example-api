var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "it's working");

app.Run();
