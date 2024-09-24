using Microsoft.AspNetCore.Mvc;
using Vite.AspNetCore;

namespace WebApp.Controllers
{
    public class ViteManifestController(IViteManifest manifest) : Controller
    {
        public IActionResult Index()
        {
            var files = manifest.Keys;

            return View(files);
        }
    }
}
