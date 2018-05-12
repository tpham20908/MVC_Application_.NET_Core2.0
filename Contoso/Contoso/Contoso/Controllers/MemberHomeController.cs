using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.Controllers
{
    //[Route("Members")]
    //[Route("[controller]/[action]")]
    [Route("[controller]")]
    public class MemberHomeController : Controller
    {
        [Route("")]
        //[Route("Index")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("access")]
        public IActionResult AccessGranted()
        {
            return View();
        }
    }
}