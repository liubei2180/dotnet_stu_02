using MediatR;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();

builder.Services.AddMediatR(typeof(Program).Assembly);



// builder.Services.AddTransient<IBookService, BookService>();// 每次都是新的实例
builder.Services.AddScoped<IBookService, BookService>(); // 一次生命周期内只使用一个对象；注册，用前面的接口，后面的实现
// builder.Services.AddSingleton<IBookService, BookService>(); // 一次应用程序只使用一个对象（线程安全问题）

// builder.Services.AddMediaR




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.Run(); // 启动后，后面的代码不会被执行。等到停止后，再执行。
