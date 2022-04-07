using System.Net.WebSockets;
using WebSocketApi.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddWebSocketServerConnectionManager();

var app = builder.Build();
app.UseWebSockets();
app.UseWebSocketServer();

app.MapGet("/", () => "Hello World!");

app.Run();

