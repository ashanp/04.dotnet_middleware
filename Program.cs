using System.Diagnostics;
using System.Net.Mime;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Extensions.Primitives;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// middleware 1
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    var requestPath = context.Request.Path;
    await context.Response.WriteAsync("app.Use() one\n");
    await context.Response.WriteAsync($"{requestPath}\n");
    await next(context);
});

// middleware 2
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    var requestPath = context.Request.Path;
    await context.Response.WriteAsync("2nd Run()\n");
    await context.Response.WriteAsync($"{requestPath}\n");
    await next(context);
});

// middleware 3
app.Run(async (HttpContext context) => {
    var response = context.Response;
    await context.Response.WriteAsync("3nd Run()\n");
    await context.Response.WriteAsync($"{response}\n");
});
app.Run();
