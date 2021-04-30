using AppCochesMariadb.Data;
using AppCochesMariadb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AppCochesMariadb.Controllers
{
    public class HomeController : Controller
    {
        CochesContext context;
        public HomeController(CochesContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {

            return View(this.context.Coches.ToList()); 
        }

      
    }
}
