using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StremioAddonExample.Models;

namespace StremioAddonExample.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        const string METAHUB_URL = "https://images.metahub.space/poster/medium/{0}/img";

        private static readonly Meta[] metas = new Meta[]
        {
            new Meta() {Id= "tt0032138", Name=  "The Wizard of Oz", Genres = new string[] { "Adventure", "Family", "Fantasy", "Musical" } },
            new Meta() {Id= "tt0017136", Name=  "Metropolis", Genres = new string[] { "Drama", "Sci-Fi" } },
            new Meta() {Id= "tt0051744", Name=  "House on Haunted Hill", Genres = new string[] { "Horror", "Mystery" } },
            new Meta() {Id= "tt1254207", Name=  "Big Buck Bunny", Genres = new string[] { "Animation", "Short", "Comedy" } },
            new Meta() {Id= "tt0031051", Name=  "The Arizona Kid", Genres = new string[] { "Music", "War", "Western" } },
            new Meta() {Id= "tt0137523", Name=  "Fight Club", Genres = new string[] { "Drama" } },
            new Meta() {
                Id = "tt1748166",
                Name =  "Pioneer One",
                Genres = new string[] { "Drama" } ,
                Videos = new Video[] {
                    new Video() {Id="tt1748166:1:1", Season = 1, Episode = 1, Title = "Earthfall", PublishedAt = "2010-06-16"}
                }
            },
            new Meta() {
                Id = "tt0147753",
                Name =  "Captain Z-Ro",
                Description = "From his secret laboratory, Captain Z-Ro and his associates use their time machine, the ZX-99, to learn from the past and plan for the future.",
                ReleaseInfo = "1955-1956",
                Genres = new string[] { "Sci-Fi" },
                Videos = new Video[] {
                    new Video() {Id="tt0147753:1:1", Season = 1, Episode = 1, Title = "Christopher Columbus", PublishedAt = "1955-12-18"},
                    new Video() {Id="tt0147753:1:1", Season = 1, Episode = 2, Title = "Daniel Boone", PublishedAt = "2010-06-25"},
                }
            }
        };

        private static readonly Meta[] catalog = metas
            .Select(x =>
            {
                if (x.Videos != null)
                {
                    x.Type = MetaType.series.ToString();
                }
                else
                {
                    x.Type = MetaType.movie.ToString();
                }

                x.Poster = string.Format(METAHUB_URL, x.Id);

                return x;
            })
            .ToArray();

        // GET /catalog
        [HttpGet("{type}/{id}")]
        public JsonResult Get(string type, string id)
        {
            var res = catalog.Where(x => x.Type == type.ToString());

            return new JsonResult(new { metas = res });
        }
    }
}
