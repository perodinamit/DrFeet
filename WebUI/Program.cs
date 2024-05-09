using Application.Services;
using Domain.Entities;
using Domain.Repository;
using Infrastructure.Context;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using Serilog;
using WebUI.Areas.Identity;
using QuestPDF.Infrastructure;
using System.Configuration;
using Infrastructure.ErrorHandling;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));


var configuration = builder.Configuration;
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(
    options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();


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
builder.Services.AddScoped<IGenericRepository<Decoration>, DecorationRepository>();
builder.Services.AddScoped<IDecorationRepository, DecorationRepository>();
builder.Services.AddScoped<IGenericRepository<Material>, MaterialRepository>();
builder.Services.AddScoped<IMaterialRepository, MaterialRepository>();
builder.Services.AddScoped<IGenericRepository<Supplier>, SupplierRepository>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();
builder.Services.AddScoped<ICalculationRepository, CalculationService>();
builder.Services.AddScoped<IGenericRepository<Miscellaneous>, MiscellaneousRepository>();
builder.Services.AddScoped<IMiscellaneousRepository, MiscellaneousRepository>();


builder.Services.AddScoped<TopService>();
builder.Services.AddScoped<ColorService>();
builder.Services.AddScoped<LiningService>();
builder.Services.AddScoped<SoleService>();
builder.Services.AddScoped<PurposeService>();
builder.Services.AddScoped<ShoeService>();
builder.Services.AddScoped<ImageService>();
builder.Services.AddScoped<DocumentPDFService>();
builder.Services.AddScoped<DecorationService>();
builder.Services.AddScoped<MaterialService>();
builder.Services.AddScoped<SupplierService>();
builder.Services.AddScoped<CalculationService>();
builder.Services.AddScoped<MiscellaneousService>();

builder.Services.AddMudServices();
builder.Services.AddControllersWithViews();

QuestPDF.Settings.License = LicenseType.Community;
QuestPDF.Settings.EnableCaching = true;

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    
    if (app.Environment.IsDevelopment())
    {
        await context.Database.MigrateAsync();
    }

    if (!context.Roles.Any())
    {
        await ContextSeed.SeedRolesAsync(roleManager);

    }

    await DefaultUserSeed.SeedDefaultUserAsync(userManager);
}

app.Run();