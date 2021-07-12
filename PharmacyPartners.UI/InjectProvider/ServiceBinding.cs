using Microsoft.Extensions.DependencyInjection;
using PharmacyUI.DataProviders.IProviders;
using PharmacyUI.DataProviders.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyPartners.UI.InjectProvider
{
    public static class ServiceBinding
    {
        public static IServiceCollection InjectServices(this IServiceCollection service)
        {
            service.AddScoped<ISubscriptionProvider, SubscriptionProvider>();
            service.AddScoped<ISalesDataProvider, SalesDataProvider>();
            return service;
        }
    }
}
