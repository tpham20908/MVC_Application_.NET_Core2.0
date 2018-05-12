using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.Controllers
{
    public class MemberHomeController : Controller
    {
        [Route("Members")]
        public IActionResult Index()
        {
            return View();
        }
    }
}