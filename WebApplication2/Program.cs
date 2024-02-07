// Эта строка создает экземпляр WebApplicationBuilder, который используется для конфигурации приложения.
var builder = WebApplication.CreateBuilder(args);


// Добавление сервисов в контейнер зависимостей:
builder.Services.AddControllersWithViews();
//Создание экземпляра WebApplication
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
     app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
