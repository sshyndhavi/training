﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace TokenJWT.Controllers
{
    public class ValueController : ApiController
    {
        // GET: Value
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}