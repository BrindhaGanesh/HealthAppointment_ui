using HealthcareFrontend.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// --- ADD THIS LINE BELOW ---
// This tells Blazor how to find your API. 
// Use the exact port (5260) from your API terminal.
builder.Services.AddScoped(sp => new HttpClient 
{ 
    BaseAddress = new Uri("https://apihealth-hgd6fchsh0a3hddf.brazilsouth-01.azurewebsites.net/") 
});
// ---------------------------

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();
app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();