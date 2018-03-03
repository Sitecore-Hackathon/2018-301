using System.Web.Mvc;
using Sitecore.XA.Foundation.Mvc.Controllers;
using Hacksite.Repository.Interfaces;

namespace Hacksite.Controllers
{
    public class CarouselController : StandardController
    {

        private readonly ICarouselRepository _repository;
        // GET: Curousel
        public ActionResult GetCarousel()
        {
            return View();
        }

        public CarouselController(ICarouselRepository repository)
        {
            _repository = repository;
        }

        protected override object GetModel()
        {
            return _repository.GetModel();
        }
    }
}