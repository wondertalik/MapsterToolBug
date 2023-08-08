using MapsterToolBug.Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddExampleServices();

WebApplication app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
