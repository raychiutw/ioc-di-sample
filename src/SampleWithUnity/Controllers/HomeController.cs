using System.Web.Mvc;
using SampleWithUnity.Service;

namespace SampleWithUnity.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            this._productService = productService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var wording = string.Join(",", this._productService.GetAll());

            ViewBag.Message = $"Your application description page. : {wording}";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}