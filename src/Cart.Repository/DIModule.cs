using Cart.DAL;
using Cart.Repository.Common;
using System;

namespace Cart.Repository
{
    public class DIModule : Ninject.Modules.NinjectModule
    {
        #region Methods

        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            //Note: Our fake context will act as database
            Bind<ICartContext>().To<CartContext>().InSingletonScope();
            Bind<ICartRepository>().To<CartRepository>();
        }

        #endregion Methods
    }
}