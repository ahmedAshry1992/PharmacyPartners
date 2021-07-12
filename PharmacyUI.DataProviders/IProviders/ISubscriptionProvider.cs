using PharmacyUI.Models.WebRequest.Request.Subscription;
using PharmacyUI.Models.WebRequest.Response.Subscription;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyUI.DataProviders.IProviders
{
    public interface ISubscriptionProvider
    {
        #region Subscription
        Task<LogInResponse> UserLogIn(LogInRequest request);
        #endregion
    }
}
