using PharmacyUI.Configurations.Helpers;
using PharmacyUI.DataProviders.IProviders;
using PharmacyUI.Models.WebRequest.Request.Subscription;
using PharmacyUI.Models.WebRequest.Response.Subscription;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyUI.DataProviders.Providers
{
    public class SubscriptionProvider: ISubscriptionProvider
    {
        public async Task<LogInResponse> UserLogIn(LogInRequest request)
        {
            return await APIInvoker.PostRequest<LogInResponse>(request, APIOrigin.Login());
        }
    }
}
