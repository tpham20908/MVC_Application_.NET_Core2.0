using ImageGallery.Datas.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageGallery.Datas
{
    public class ImagesGalleryDbContext : DbContext
    {
        public ImagesGalleryDbContext(DbContextOptions options) : base(options) { }

        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }
    }
}
