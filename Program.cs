using Microsoft.EntityFrameworkCore;
using Pokedex.Configuration;
using Pokedex.Interface;
using Pokedex.Interface.Implementation;
using Pokedex.Interface.Mappings;
using Pokedex.Postgres;
using Pokedex.Postgres.Seeder;
using Pokedex.Repository;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<ApplicationContextDb>(options => options.UseNpgsql(builder.Configuration["Database:Pokedex"]));
builder.Services.AddScoped<IPokemonRepository, PokemonRepository>();
builder.Services.AddScoped<IPokemonManager, PokemonManager>();
builder.Services.AddTransient<PokemonSeeder>();
builder.Services.AddAutoMapper(typeof(NewPokemonMappingProfile));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwaggerUI();

if (args.Length == 1 && args[0].ToLower() == "seeddata")
{
    SeedData(app);
}

void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<PokemonSeeder>();
        service.SeedDataContext();
    }
}

//Configure the HTTP request pipeline.

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseSwagger(options => options.SerializeAsV2 = true);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Pokemons",
    pattern: "{controller=Pokemons}/{action=Index}/{id?}");

app.Run();
