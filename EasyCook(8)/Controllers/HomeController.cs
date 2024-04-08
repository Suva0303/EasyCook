using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using EasyCook.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EasyCook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _hostEnvironment;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/UploadPhoto")]
        public async Task<IActionResult> UploadPhoto(IFormFile photo)
        {
            if (photo != null && photo.Length > 0)
            {
                try
                {
                    // Генерируем уникальное имя файла
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(photo.FileName);
                    // Путь для сохранения файла в папку "wwwroot/Uploads"
                    var filePath = Path.Combine(_hostEnvironment.WebRootPath, "Uploads", fileName);

                    // Сохраняем файл
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await photo.CopyToAsync(stream);
                    }

                    ViewBag.Message = "Файл успешно загружен";
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Произошла ошибка при загрузке файла: " + ex.Message;
                }
            }
            else
            {
                ViewBag.Message = "Выберите файл для загрузки";
            }

            // Перенаправление на другую страницу после загрузки
            return RedirectToAction("Index");
        }

        // Другие методы контроллера
        // ...

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}