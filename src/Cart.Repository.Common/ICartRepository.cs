using Cart.Model.Common;
using System;
using System.Collections.Generic;

namespace Cart.Repository.Common
{
    public interface ICartRepository
    {
        #region Methods

        /// <summary>
        /// Adds to cart.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        bool AddToCart(int productId);

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

        /// <summary>
        /// Removes from cart.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        bool RemoveFromCart(int productId);

        #endregion Methods
    }
}