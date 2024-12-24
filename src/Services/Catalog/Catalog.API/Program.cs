var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configura the HTTP reuqest pipeline.

app.Run();
