using Microsoft.AspNetCore.SystemWebAdapters;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSystemWebAdapters();
builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));
builder.Services.AddRazorPages();
var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseSystemWebAdapters();

app.MapReverseProxy();
app.MapRazorPages();

app.Run();
