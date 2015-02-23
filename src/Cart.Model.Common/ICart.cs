using System;
using System.Collections.Generic;

namespace Cart.Model.Common
{
    public interface ICart
    {
        #region Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>
        List<IProduct> Items { get; set; }

        #endregion Properties
    }
}