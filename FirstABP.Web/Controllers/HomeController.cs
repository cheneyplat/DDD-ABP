﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace FirstABP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FirstABPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}