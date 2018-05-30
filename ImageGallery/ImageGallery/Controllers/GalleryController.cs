using ImageGallery.Datas;
using ImageGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImageGallery.Controllers
{
    public class GalleryController : Controller
    {
        private IImage _imageService;

        public GalleryController(IImage imageService)
        {
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            var imageList = _imageService.GetAll();

            var model = new GalleryIndexModel()
            {
                Images = imageList,
                SearchQuery = ""
            };

            return View(model);
        }
    }
}