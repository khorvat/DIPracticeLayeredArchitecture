using Cart.Model.Common;
using System;
using System.Collections.Generic;

namespace Cart.Model
{
    public class Cart : ICart
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
        public List<IProduct> Items { get; set; }

        #endregion Properties
    }
}