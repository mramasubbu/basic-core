var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/test", () => "Hello World Test!");
app.MapGet("/health", () => "Health Test!");

app.Run();
