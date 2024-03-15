using Application.Services;
using Domain.Entities;
using Domain.Repository;
using Infrastructure.Context;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using QuestPDF.Infrastructure;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

//builder.Host.UseSerilog((ctx, lc) => lc
//    .WriteTo.File(
//        "Logs\\log.txt"
//        , fileSizeLimitBytes: 10 * 1024 * 1024 // 10MB limit
//        , restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Error
//        , rollOnFileSizeLimit: true
//        , retainedFileCountLimit: 10)
//    );

builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

var configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IGenericRepository<Top>, TopRepository>();
builder.Services.AddScoped<ITopRepository, TopRepository>();
builder.Services.AddScoped<IGenericRepository<ColorType>, ColorRepository>();
builder.Services.AddScoped<IColorRepository, ColorRepository>();
builder.Services.AddScoped<IGenericRepository<Lining>, LiningRepository>();
builder.Services.AddScoped<ILiningRepository, LiningRepository>();
builder.Services.AddScoped<IGenericRepository<Sole>, SoleRepository>();
builder.Services.AddScoped<ISoleRepository, SoleRepository>();
builder.Services.AddScoped<IGenericRepository<Purpose>, PurposeRepository>();
builder.Services.AddScoped<IPurposeRepository, PurposeRepository>();

builder.Services.AddScoped<TopService>();
builder.Services.AddScoped<ColorService>();
builder.Services.AddScoped<LiningService>();
builder.Services.AddScoped<SoleService>();
builder.Services.AddScoped<PurposeService>();
builder.Services.AddScoped<ShoeService>();
builder.Services.AddScoped<ImageService>();
builder.Services.AddScoped<DocumentPDFService>();


QuestPDF.Settings.License = LicenseType.Community;
QuestPDF.Settings.EnableCaching = true;

builder.Services.AddMudServices();

builder.Services.AddControllersWithViews();
var connectionString = configuration.GetConnectionString("SekloWebConnectionString");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
