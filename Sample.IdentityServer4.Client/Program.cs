var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = "cookie";
    options.DefaultChallengeScheme = "oidc";
})
.AddCookie("cookie")
.AddOpenIdConnect("oidc", options =>
{
    options.Authority = "https://localhost:44343";
    options.ClientId = "oidcMVCApp";
    options.ClientSecret = "Sample.IdentityServer4";

    options.ResponseType = "code";
    options.UsePkce = true;
    options.ResponseMode = "query";

    options.Scope.Add("weatherApi.read");
    options.SaveTokens = true;
});
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
