using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyUI.Configurations.Helpers
{
    public class APIOrigin
    {
        private const string endPoint = "https://localhost:44337/api/v1";

        #region Subscription
        public static string Login()
        {
            return $"{endPoint}/management/user/login";
        }
        #endregion

        #region Sales
        public static string ProdctToSellSearch()
        {
            return $"{endPoint}/management/sales/productsearch";
        }
        public static string InvoiceTypes()
        {
            return $"{endPoint}/invoicetypes/sales/getall";
        }
        public static string customerSearch()
        {
            return $"{endPoint}/management/customer/search";
        }
        public static string InvoiceCraete()
        {
            return $"{endPoint}/invoice/sales/add";
        }
        public static string InvoiceEdit()
        {
            return $"{endPoint}/invoice/sales/edit";
        }

        
        public static string ProdctSearch()
        {
            return $"{endPoint}/servises/product/search";
        }
        
        #endregion
    }
}
