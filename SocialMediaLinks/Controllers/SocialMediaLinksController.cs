using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SocialMediaLinks.Options;

namespace SocialMediaLinks.Controllers
{
    public class SocialMediaLinksController : Controller
    {
        private readonly SocialMediaLinksOptions _socialMediaLinksOptions;

        public SocialMediaLinksController(IOptions<SocialMediaLinksOptions> options)
        {
            _socialMediaLinksOptions = options.Value;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["FacebookLink"] = _socialMediaLinksOptions.Facebook;
            ViewData["InstagramLink"] = _socialMediaLinksOptions.Instagram;
            ViewData["TwitterLink"] = _socialMediaLinksOptions.Twitter;
            ViewData["YoutubeLink"] = _socialMediaLinksOptions.Youtube;

            return View();
        }
    }
}
