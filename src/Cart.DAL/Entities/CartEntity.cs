using System;
using System.Collections.Generic;

namespace Cart.DAL
{
    public class CartEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>
        public List<ProductEntity> Items { get; set; }

        #endregion Properties
    }
}