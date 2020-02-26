using System.Web.Mvc;
using AutoMapper;
using SampleWithUnity.Service;

namespace SampleWithUnity.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public HomeController(
            IProductService productService,
            IMapper mapper)
        {
            this._productService = productService;
            this._mapper = mapper;
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