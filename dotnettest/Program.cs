var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/{userId}", (string userId) =>
{
    Console.WriteLine(userId);
    return "Hello World!";
});

app.Run();