using System.Collections.Generic;
using Sitecore.XA.Foundation.Variants.Abstractions.Models;

namespace Hacksite.Repository.Models
{
    public class RepositoryCarouselModel : VariantsRenderingModel
    {
        public List<CarouselItemModel> CarouselModel { get; set; }
    }
}
