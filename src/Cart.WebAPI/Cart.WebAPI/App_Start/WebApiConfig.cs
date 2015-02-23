using System;
using System.Web.Http;

namespace Cart.WebAPI
{
    public static class WebApiConfig
    {
        #region Methods

        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
        }

        #endregion Methods
    }
}