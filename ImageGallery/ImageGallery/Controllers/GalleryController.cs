using ImageGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImageGallery.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var model = new GalleryIndexModel()
            {

            };

            return View();
        }
    }
}