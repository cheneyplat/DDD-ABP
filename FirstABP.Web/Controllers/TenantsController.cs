﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using FirstABP.Authorization;
using FirstABP.MultiTenancy;

namespace FirstABP.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : FirstABPControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}