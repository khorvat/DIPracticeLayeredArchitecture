using Cart.Service.Common;
using System;

namespace Cart.Service.Ex
{
    public class DIModule : Ninject.Modules.NinjectModule
    {
        #region Methods

        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            Bind<ICartService>().To<CartServiceEx>();
        }

        #endregion Methods
    }
}