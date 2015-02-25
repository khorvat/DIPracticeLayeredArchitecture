using Cart.Model.Common;
using Cart.Repository.Common;
using Cart.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cart.Service.Ex
{
    public class CartServiceEx : ICartService
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CartServiceEx" /> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public CartServiceEx(ICartRepository repository)
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
            IProduct product = Repository.GetAllProducts().FirstOrDefault(p => p.Id.Equals(productId));
            if (product != null)
            {
                if (!product.InStock)
                {
                    throw new ArgumentOutOfRangeException("InStock");
                }
                if (product.ExpDate <= DateTime.UtcNow)
                {
                    throw new ArgumentNullException("Exp. Date");
                }
                return Repository.AddToCart(productId);
            }
            return false;
        }

        /// <summary>
        /// Gets all available products.
        /// </summary>
        /// <returns></returns>
        public List<IProduct> GetAllAvailableProducts()
        {
            return Repository.GetAllProducts().Where(p => p.InStock && p.ExpDate > DateTime.UtcNow).ToList();
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