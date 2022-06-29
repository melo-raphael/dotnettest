var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/{userId}", (string userId) =>
{
    Console.WriteLine(userId);
    return "Hello World!";
});

builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.WithOrigins("*")
        .AllowAnyMethod()
        .AllowAnyHeader();
}));

app.UseCors("MyPolicy");

app.Run("http://*:5000");