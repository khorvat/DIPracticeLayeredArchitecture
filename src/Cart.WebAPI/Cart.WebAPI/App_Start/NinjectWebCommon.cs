[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Cart.WebAPI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Cart.WebAPI.App_Start.NinjectWebCommon), "Stop")]

namespace Cart.WebAPI.App_Start
{
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Extensions.Interception.Infrastructure.Language;
    using Ninject.Web.Common;
    using Ninject.Web.WebApi;
    using System;
    using System.Linq;
    using System.Web;
    using System.Web.Http;

    public static class NinjectWebCommon
    {
        #region Fields

        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        #endregion Fields

        #region Methods

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var settings = new NinjectSettings();
            settings.LoadExtensions = true;
            settings.ExtensionSearchPatterns = settings.ExtensionSearchPatterns.Union(new string[] { "Cart.*.dll" }).ToArray();
            var kernel = new StandardKernel(settings);
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);

                // Install Ninject-based IDependencyResolver into the Web API configuration to set Web API Resolver
                GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            //kernel.Bind<Cart.Common.ICartInterceptor>().To<GreedyInterceptor>();
            //Note: This isn't a good way to obtain the Cart Service implementation type. This is Ninject limitation.
            var cartService = kernel.Get<Cart.Service.Common.ICartService>();
            kernel.Rebind<Cart.Service.Common.ICartService>().To(cartService.GetType()).Intercept().With<GreedyInterceptor>();
        }

        #endregion Methods
    }
}