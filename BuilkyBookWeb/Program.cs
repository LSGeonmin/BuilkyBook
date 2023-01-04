// entry point>?
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// mvc를 위한 서비스  
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
// request로부터 이어지는 파이프라인 
// 순서가 어느정도 정해져있음
// 빌더를 통해 서비스를 구축, 파이프라인 생성 후 app.Run()
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

// 라우팅
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
