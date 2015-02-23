using System;
using System.Collections.Generic;

namespace Cart.DAL
{
    public interface ICartContext
    {
        #region Properties

        /// <summary>
        /// Gets or sets the carts.
        /// </summary>
        /// <value>The carts.</value>
        List<CartEntity> Carts { get; set; }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>The products.</value>
        List<ProductEntity> Products { get; set; }

        #endregion Properties
    }
}