using travishendricks.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// WebApplicationBuilder builder = WebApplication.CreateBuilder();
// // Add services to the container.
// builder.Services.AddControllersWithViews();
// builder.Services.Configure<GzipCompressionProviderOptions>(options => options.Level = CompressionLevel.Fastest);

// builder.Services.AddResponseCompression(options =>
// {
//     options.Providers.Add<GzipCompressionProvider>();
//     options.EnableForHttps = true;
// });

// builder.WebHost.ConfigureKestrel(serverOptions =>
// {
// });
builder.Services.AddHttpClient();
builder.Services.AddTransient<IProjectService, ProjectService>();
builder.Services.AddTransient<IHttpRequestService, HttpRequestService>();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
