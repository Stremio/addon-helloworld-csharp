using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StremioAddonExample.Models;

namespace StremioAddonExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StreamController : ControllerBase
    {
        const string METAHUB_URL = "https://images.metahub.space/poster/medium/{0}/img";

        private static readonly Dictionary<string, Stream[]> movies = new Dictionary<string, Stream[]>()
        {
            { "tt0032138",   new Stream[] { new Stream { Title = "Torrent", InfoHash = "24c8802e2624e17d46cd555f364debd949f2c81e", FileIdx = 0 } } },
            { "tt0017136",   new Stream[] { new Stream { Title = "Torrent", InfoHash = "dca926c0328bb54d209d82dc8a2f391617b47d7a", FileIdx = 1 } } },
            { "tt0051744",   new Stream[] { new Stream { Title = "Torrent", InfoHash = "9f86563ce2ed86bbfedd5d3e9f4e55aedd660960"} } },
            { "tt1254207",   new Stream[] { new Stream { Title = "HTTP URL", Url = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4" } } },
            { "tt0031051",   new Stream[] { new Stream { Title = "YouTube", YtId = "m3BKVSpP80s"} } },
            { "tt0137523",   new Stream[] { new Stream { Title = "External URL", ExternalUrl = "https://www.netflix.com/watch/26004747" } } },
        };

        private static readonly Dictionary<string, Stream[]> series = new Dictionary<string, Stream[]>()
        {
            { "tt1748166:1:1",   new Stream[] { new Stream { Title = "Torrent", InfoHash = "07a9de9750158471c3302e4e95edb1107f980fa6" } } },
            { "tt0147753:1:1",   new Stream[] { new Stream { Title = "YouTube", YtId = "5EQw5NYlbyE" } } },
            { "tt0147753:1:2",   new Stream[] { new Stream { Title = "YouTube", YtId = "ZzdBKcVzx9Y" } } },
        };

        // GET /streams/movie/tt0032138
        [HttpGet("{type}/{id}")]
        public JsonResult Get(string type, string id)
        {
            var dictId = id.Split('.')[0];
            Dictionary<string, Stream[]> collection = null;
            if(type == "movie")
            {
                collection = movies;
            }
            else if (type == "series")
            {
                collection = series;
            }
            else
            {
                return new JsonResult(new object[0]);
            }

            Stream[] res = collection.GetValueOrDefault(dictId);

            return new JsonResult(new { streams = res });
        }
    }
}
