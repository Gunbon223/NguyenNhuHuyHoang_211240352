using Microsoft.AspNetCore.Mvc;

namespace NguyenNhuHuyHoang_211240352.Controllers
{
    public class BaiThi : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			// Các cấu hình khác...

			app.UseStaticFiles(); // Cấu hình phục vụ các tệp tin tĩnh (css, js, hình ảnh...)

			// Các cấu hình khác...
		}
	}
}
