using BuilkyBookWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BuilkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        // ApplicationDbContext를 Program.cs에서 DI하였기 때문에 그냥 가져와서 사용가능
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db) { _db = db; }
        public IActionResult Index()
        {
            var objCategoryList = _db.Categories.ToList();

            return View();
        }
    }
}
