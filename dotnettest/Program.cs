var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.WithOrigins("*")
        .AllowAnyMethod()
        .AllowAnyHeader();
}));

var app = builder.Build();

app.MapGet("/users/{userId}", (string userId) =>
{
    Console.WriteLine(userId);
    return $"Hello World! {userId}";
});


app.UseCors("MyPolicy");

app.Run("http://*:5000");