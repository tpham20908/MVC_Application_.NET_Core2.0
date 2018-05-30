using System.Collections.Generic;
using System.Linq;
using ImageGallery.Datas;
using ImageGallery.Datas.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageGallery.Services
{
    public class ImageService : IImage
    {
        private ImagesGalleryDbContext _context;

        public ImageService(ImagesGalleryDbContext context)
        {
            _context = context;
        }

        public IEnumerable<GalleryImage> GetAll()
        {
            return _context.GalleryImages
                .Include(img => img.Tags);
        }

        public GalleryImage GetById(int id)
        {
            return _context.GalleryImages.Find(id);
        }

        public IEnumerable<GalleryImage> GetWithTag(string tag)
        {
            return GetAll().Where(img => img.Tags.Any(t => t.Description == tag));
        }
    }
}
