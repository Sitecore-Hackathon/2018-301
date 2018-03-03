using Hacksite.Repository.Interfaces;
using Hacksite.Repository.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;

namespace Hacksite.Repository
{
    public class CarouselRepository : VariantsRepository, ICarouselRepository
    {
        public override IRenderingModelBase GetModel()
        {
            var model = new RepositoryCarouselModel();
            GetCaraousalModel(model);
            FillBaseProperties(model);
            return model;
        }

        public RepositoryCarouselModel GetCarousel()
        {
            return new RepositoryCarouselModel();
        }

        private static void GetCaraousalModel(RepositoryCarouselModel model)
        {
            var item = RenderingContext.Current.Rendering.DataSource;
        }
    }
}
