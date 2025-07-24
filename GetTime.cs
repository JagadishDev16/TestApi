using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/datetime", () =>
{
    return DateTime.Now.ToString("o"); // ISO 8601 format
});

app.Run();
