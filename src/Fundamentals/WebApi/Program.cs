using WebApi;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapEntities();

app.Run();


// Partial class

// Partial method