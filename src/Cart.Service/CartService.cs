using Cart.Model.Common;
using Cart.Repository.Common;
using Cart.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cart.Service
{
    public class CartService : ICartService
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CartService" /> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public CartService(ICartRepository repository)
        {
            this.Repository = repository;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the repository.
        /// </summary>
        /// <value>The repository.</value>
        protected ICartRepository Repository { get; private set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Adds to cart.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public bool AddToCart(int productId)
        {
            if (!Repository.GetAllProducts().First(p => p.Id.Equals(productId)).InStock)
            {
                throw new ArgumentOutOfRangeException("InStock");
            }
            return Repository.AddToCart(productId);
        }

        /// <summary>
        /// Gets all available products.
        /// </summary>
        /// <returns></returns>
        public List<IProduct> GetAllAvailableProducts()
        {
            return Repository.GetAllProducts().Where(p => p.InStock).ToList();
        }

        /// <summary>
        /// Gets my cart.
        /// </summary>
        /// <returns></returns>
        public ICart GetMyCart()
        {
            return Repository.GetAllCarts().FirstOrDefault();
        }

        /// <summary>
        /// Removes from cart.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public bool RemoveFromCart(int productId)
        {
            return Repository.RemoveFromCart(productId);
        }

        #endregion Methods
    }
}