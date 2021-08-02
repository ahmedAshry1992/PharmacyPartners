using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmacyUI.Models.WebRequest.Response;
using PharmacyPartners.UI.Infrastructre.Extensions;
using PharmacyUI.DataProviders.IProviders;
using PharmacyUI.Models.WebRequest.Request.Invoice;
using PharmacyUI.Models.WebRequest.Response.Invoice;
using PharmacyUI.Models.WebRequest.Response.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;

namespace PharmacyPartners.UI.Areas.Pharmacy.Controllers
{
    [Area("Pharmacy")]
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class InvoiceController : Controller
    {
        private readonly ISalesDataProvider _salesDataProvider;
        public InvoiceController(ISalesDataProvider salesDataProvider)
        {
            _salesDataProvider = salesDataProvider;
        }
        #region Sales Invoice
        [Route("/invoice/create", Name = "invoicecreate")]
        public async Task<IActionResult> CreateSalesInvoice()
        {
            var invTypes = await _salesDataProvider.InvoiceTypes();
            if (invTypes.success && invTypes.data.Count() > 0)
            {
                ViewBag.invoiceTypes = invTypes.data;
            }
            return View();
        }
        #endregion

        #region Purchase Invoice
        [Route("/invoice/puchase/create", Name = "invoicepuchasecreate")]
        public async Task<IActionResult> CreatePurchaseInvoice()
        {
            return View();
        }
        #endregion


        #region Partial views


        [Route("/invoice/getproductlist", Name = "getproductlist")]
        public async Task<PartialViewResult> GridSectionProductList(string request)
       {
            int i = 0;
            if (int.TryParse(request, out i))
            {
                var result = await _salesDataProvider.ProdctToSellSearchByCode(i.ToString());
                return PartialView("_searchSection", result.data);
            }
            else
            {
                var result = await _salesDataProvider.ProdctSearchByName(request);
                return PartialView("_ProductSearch", result.data);
            }
               
        }

        [Route("/invoice/getproductlistgrid", Name = "getproductlistgrid")]
        public async Task<PartialViewResult> GridSectionProductListTable(string request) {

            var result = await _salesDataProvider.ProdctToSellSearchByCode(request);
            return PartialView("_searchSection", result.data);
        }

        [Route("/invoice/getctomerlist", Name = "getcustomerlist")]
        public async Task<PartialViewResult> GetCustomertList(string request)
        {
            var result = await _salesDataProvider.customerSearch(request);
            return PartialView("_customerAutocomplete", result.data);
        }
        #endregion

        #region API
        #region Sales Invoice
        [HttpPost]
        [Route("/invoice/create", Name = "invoicecreate")]
        public async Task<Infrastructre.API.ResponseBuilder> CreateSalesInvoice(EditSalesInvoiceRequest request)
        {
            var userId = User.Identity.GetUserId();
            if (request != null && request.salesInvoiceRequest.salesProducts.Count() != 0)
            {
                request.salesInvoiceRequest.userId = userId;
                var response = await _salesDataProvider.InvoiceCreate(request);
                if (response.success && response.data != null)
                {
                    return Infrastructre.API.ResponseBuilder.CreateResponseBilder(HttpStatusCode.OK, response);
                }
            }

            return Infrastructre.API.ResponseBuilder.CreateResponseBilder(HttpStatusCode.InternalServerError, null);
        }
        [HttpPost]
        [Route("/invoice/edit", Name = "invoicedit")]
        public async Task<EditSalesInvoiceResponse> EditSalesInvoice(EditSalesInvoiceRequest request)
        {
            var userId = User.Identity.GetUserId();

            request.salesInvoiceRequest.userId = userId;
            var response = await _salesDataProvider.InvoiceEdit(request.salesInvoiceRequest);
            return response;
        }

        [HttpPost]
        [Route("/invoicedet/delete", Name = "invoicdetdel")]
        public async Task<ResponseBuilder> SalesInvoiceDetailsDel(int request)
        {
            var userId = User.Identity.GetUserId();

            var response = await _salesDataProvider.DeleteInvoiceDet(request);
            return response;
        }


        #endregion

        #region Purchase Invoice
        #endregion
        #endregion
    }
}
