using BusinessLayer.Concrete;
using DataAccesslayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class GuideController : Controller
    {
        GuideManager GuideManager = new GuideManager(new EfGuideDal());
      
        public IActionResult Index()
        {
            var values = GuideManager.TGetList();
            return View(values);
        }
    }
}
