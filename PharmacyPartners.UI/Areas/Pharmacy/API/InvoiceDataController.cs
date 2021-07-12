using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmacyUI.DataProviders.IProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyPartners.UI.Areas.Pharmacy.API
{
    [Area("Pharmacy")]
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class InvoiceDataController : Controller
    {
        private readonly ISalesDataProvider _salesDataProvider;

        public InvoiceDataController(ISalesDataProvider salesDataProvider)
        {
            _salesDataProvider = salesDataProvider;
        }


        

    }
}
