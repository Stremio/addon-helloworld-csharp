using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace StremioAddonExample.Controllers
{

    [ApiController]
    public class ManifestController : ControllerBase
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public ManifestController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [Route("manifest.json")]
        [HttpGet]
        public ActionResult<string> Get()
        {
            // TODO: IMemoryCache
            string contentRootPath = _hostingEnvironment.ContentRootPath;
            var manifest = System.IO.File.ReadAllText(contentRootPath + "/manifest.json");

            return manifest;
        }
    }
}
