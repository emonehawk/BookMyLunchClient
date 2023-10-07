using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using BookMyLunchClient;
using BookMyLunchClient.Services;
using BookMyLunchClient.Model;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

#region Radzen
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();
#endregion

#region Services
builder.Services.AddScoped<SystemNotifyService>();
builder.Services.AddScoped<UserService>();
#endregion

#region Model
builder.Services.AddScoped<LoginModel>();
builder.Services.AddScoped<CreateModel>();
#endregion

await builder.Build().RunAsync();
