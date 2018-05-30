using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGallery.Datas.Models
{
    public class GalleryImage
    {
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public string Url { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}
