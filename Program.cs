var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/test", () => "It works!");
app.MapGet("/health", () => "It is healthy!");

app.Run();