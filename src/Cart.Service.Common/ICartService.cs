using Cart.Model.Common;
using System;
using System.Collections.Generic;

namespace Cart.Service.Common
{
    public interface ICartService
    {
        #region Methods

        /// <summary>
        /// Adds to cart.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        bool AddToCart(int productId);

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

        /// <summary>
        /// Removes from cart.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        bool RemoveFromCart(int productId);

        #endregion Methods
    }
}