using Microsoft.AspNetCore.Mvc;
using StremioAddonExample.Models;
using Newtonsoft.Json;

namespace StremioAddonExample.Controllers
{
    [ApiController]
    public class ManifestController : ControllerBase
    {
        private static readonly Manifest manifest = new Manifest
        {
            id = "org.stremio.asp.net.core.example",
            version = "0.0.1",
            name = "C# ASP.NET CORE 2.2 Stremio addon example",
            description = "Sample addon made with Express providing a few public domain movies",
            resources = new object[] {
                "catalog",
                "meta",
                new {
                    name = "stream",
                    types = new string[] { "movie", "series" },
                    idPrefixes = new string[] { "tt" }
                }
            },
            types = new string[] { "movie", "series" },
            catalogs = new Catalog[]
            {
                new Catalog{ type = "movie", id = "Hello, Core movies" },
                new Catalog{ type = "series", id = "Hello, Core series" }
            }
        };

        private static readonly string manifestJSON = JsonConvert.SerializeObject(manifest);

        [Route("manifest.json")]
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(manifest);
        }
    }
}
