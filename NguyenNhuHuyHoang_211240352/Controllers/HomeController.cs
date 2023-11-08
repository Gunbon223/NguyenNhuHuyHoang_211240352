using Microsoft.AspNetCore.Mvc;
using NguyenNhuHuyHoang_211240352.Models;
using System.Diagnostics;

namespace NguyenNhuHuyHoang_211240352.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			// Các cấu hình khác...

			app.UseStaticFiles(); // Cấu hình phục vụ các tệp tin tĩnh (css, js, hình ảnh...)

			// Các cấu hình khác...
		}
	}
}