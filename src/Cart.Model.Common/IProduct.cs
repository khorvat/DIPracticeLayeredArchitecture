using System;

namespace Cart.Model.Common
{
    public interface IProduct
    {
        #region Properties

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets the expiration date.
        /// </summary>
        /// <value>The expiration date.</value>
        DateTime ExpDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the item is in stock.
        /// </summary>
        /// <value><c>true</c> if item is in stock otherwise, <c>false</c>.</value>
        bool InStock { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is deleted.
        /// </summary>
        /// <value><c>true</c> if this instance is deleted; otherwise, <c>false</c>.</value>
        bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        decimal Price { get; set; }

        #endregion Properties
    }
}