using Repro;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOptions();
builder.Services.Configure<SiteOptions>(builder.Configuration.GetSection("Site"));

var app = builder.Build();

app.Run();
