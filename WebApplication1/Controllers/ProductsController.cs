﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {

        public IActionResult Products()
        {
            return View();
        }
    }
}
