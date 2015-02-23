using Cart.Model.Common;
using System;
using System.Collections.Generic;

namespace Cart.Repository.Common
{
    public interface ICartRepository
    {
        #region Methods

        /// <summary>
        /// Gets all cart.
        /// </summary>
        /// <returns></returns>
        List<ICart> GetAllCarts();

        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns></returns>
        List<IProduct> GetAllProducts();

        #endregion Methods
    }
}