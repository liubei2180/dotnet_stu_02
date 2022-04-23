using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [Route("simple")]
    public class SimpleController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Index()
        {
            return new [] { "simple" };
        }
    }
}