using ImageGallery.Datas.Models;
using System.Collections.Generic;

namespace ImageGallery.Datas
{
    public interface IImage
    {
        IEnumerable<GalleryImage> GetAll();
        IEnumerable<GalleryImage> GetWithTag(string tag);
        GalleryImage GetById(int id);
    }
}
