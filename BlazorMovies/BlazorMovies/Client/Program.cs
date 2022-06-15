using BlazorMovies.Client;
using BlazorMovies.Client.Helpers;
using BlazorMovies.Client.Repository;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

ConfigureServices(builder.Services);

await builder.Build().RunAsync();

static void ConfigureServices(IServiceCollection services)
{
    services.AddSingleton<SingletonService>();
    services.AddTransient<TransientService>();
    services.AddSingleton<IRepository, RepositoryInMemory>();

    services.AddScoped<IHttpService, HttpService>();
    services.AddScoped<IGenreRepository, GenreRepository>();
}