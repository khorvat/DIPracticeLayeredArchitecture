using Cart.Model.Common;
using System;
using System.Collections.Generic;

namespace Cart.Service.Common
{
    public interface ICartService
    {
        #region Methods

        /// <summary>
        /// Gets all available products.
        /// </summary>
        /// <returns></returns>
        List<IProduct> GetAllAvailableProducts();

        /// <summary>
        /// Gets my cart.
        /// </summary>
        /// <returns></returns>
        ICart GetMyCart();

        #endregion Methods
    }
}