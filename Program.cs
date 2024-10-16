var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapDefaultControllerRoute();

//Works For All Controller And Route
// app.MapControllerRoute(
//     name: "generalController",
//     pattern: "{controller}/{action}/{id?}"
// );

app.MapControllerRoute(
    name: "orders",
    pattern: "{controller=Orders}/{action=Details}/{orderId:int?}"
);
app.MapControllerRoute(
    name: "blog",
    pattern: "{controller=Blog}/{action=Post}/{title}"
);
app.MapControllerRoute(
    name: "products",
    pattern: "{controller=Products}/{action=Index}"
);
app.MapControllerRoute(
    name: "createProducts",
    pattern: "{controller=Products}/{action=CreateProducts}"
);
app.MapControllerRoute(
    name: "editProducts",
    pattern: "{controller=Products}/{action=Edit}/{id:int}"
);
app.Run();
