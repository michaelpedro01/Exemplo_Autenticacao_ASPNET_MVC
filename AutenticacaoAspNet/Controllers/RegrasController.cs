﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutenticacaoAspNet.Controllers
{
    public class RegrasController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}