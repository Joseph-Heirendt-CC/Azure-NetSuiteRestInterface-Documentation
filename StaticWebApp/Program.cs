
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable serving static files
app.UseStaticFiles();

// Map the root URL to serve the index.html file
app.MapGet("/", async context =>
{
    await context.Response.SendFileAsync("wwwroot/index.html");
});

app.Run();
