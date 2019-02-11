using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StremioAddonExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        // GET /catalog
        [HttpGet]
        public ActionResult<string> Get()
        {
            // TODO:
            return "catalog";
        }
    }
}
