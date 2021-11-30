using BlazorFramework;
using BlazorFramework.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using Toolbelt.Blazor;
using Toolbelt.Blazor.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => 
    new HttpClient
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
    }.EnableIntercept(sp));

builder.Services.AddScoped<IWeatherForecastClient, WeatherForecastClient>();

builder.Services.AddSingleton<IJSInProcessRuntime>(services =>
    (IJSInProcessRuntime)services.GetRequiredService<IJSRuntime>());

builder.Services.AddLoadingBar();
builder.UseLoadingBar();

await builder.Build().RunAsync();
