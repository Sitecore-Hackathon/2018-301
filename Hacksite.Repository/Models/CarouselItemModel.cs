using Sitecore.XA.Foundation.Variants.Abstractions.Models;

namespace Hacksite.Repository.Models
{
    public class CarouselItemModel : VariantsRenderingModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
