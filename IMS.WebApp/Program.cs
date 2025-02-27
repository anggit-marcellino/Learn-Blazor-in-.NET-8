using IMS.Plugins.InMemory;
using IMS.UseCase.Inventories;
using IMS.UseCase.Inventories.Interface;
using IMS.UseCase.PluginInterface;
using IMS.UseCase.Products;
using IMS.UseCase.Products.Interface;
using IMS.WebApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<IInventoryRepository, InventoryRepository>();

builder.Services.AddTransient<IViewInventoriesByNameUseCase, ViewInventoriesByNameUseCase>();

builder.Services.AddTransient<IAddInventoryUseCase, AddInventoryUseCase>();

builder.Services.AddTransient<IEditInventoryUseCase, EditInventoryUseCase>();

builder.Services.AddTransient<IViewInventoryByIdUseCase, ViewInventoryByIdUseCase>();

builder.Services.AddTransient<IDeleteInventoryUseCase, DeleteInventoryUseCase>();

builder.Services.AddSingleton<IProductRepository, ProductRepository>();

builder.Services.AddTransient<IViewProductsByNameUseCase, ViewProductsByNameUseCase>();

builder.Services.AddTransient<IDeleteProductUseCase, DeleteProductUseCase>();

builder.Services.AddTransient<IAddProductUseCase, AddProductUseCase>();

builder.Services.AddTransient<IEditProductUseCase, EditProductUseCase>();

builder.Services.AddSingleton<IViewProductByIdUseCase, ViewProductByIdUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
