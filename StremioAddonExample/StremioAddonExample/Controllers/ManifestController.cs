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
            name = "CORE Example",
            description = "Sample addon made C# ASP.NET CORE 2.2 providing a few public domain movies",
            resources = new object[] {
                "catalog",
                "meta",
                "stream"
            },
            idPrefixes = new string[] { "tt" },
            types = new string[] { "movie", "series" },
            catalogs = new Catalog[]
            {
                new Catalog{ type = "movie", id = "coreMovies", name = "Core movies" },
                new Catalog{ type = "series", id = "coreSeries", name = "Core series" }
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
