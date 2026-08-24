var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/health", () => "It is healthy!");
app.MapGet("/test", () => "It is Test!");

app.Run();