using Microsoft.Extensions.FileProviders;
using Udemy.ToDoAppNTier.Business.DependencyResolvers.Microsoft;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDependencies();
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseStatusCodePagesWithReExecute("/Home/NotFound", "?statusCode={0}");
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider=new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
    RequestPath="/node_modules"
});

app.MapDefaultControllerRoute();

app.Run();
