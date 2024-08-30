var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello .net, I'm new to this.....!😂");

app.Run();


