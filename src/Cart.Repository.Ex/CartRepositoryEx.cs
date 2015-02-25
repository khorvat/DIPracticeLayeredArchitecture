using Cart.DAL;
using Cart.Model;
using Cart.Model.Common;
using Cart.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cart.Repository.Ex
{
    public class CartRepositoryEx : ICartRepository
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CartRepository" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public CartRepositoryEx(ICartContext context)
        {
            this.Context = context;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        /// <value>The context.</value>
        protected ICartContext Context { get; private set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Adds to cart.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public bool AddToCart(int productId)
        {
            Context.Carts.FirstOrDefault().Items.Add(Context.Products.First(p => p.Id.Equals(productId)));
            return true;
        }

        /// <summary>
        /// Gets all cart.
        /// </summary>
        /// <returns></returns>
        public List<ICart> GetAllCarts()
        {
            return new List<ICart>(AutoMapper.Mapper.Map<List<Cart.Model.Cart>>(Context.Carts));
        }

        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns></returns>
        public List<IProduct> GetAllProducts()
        {
            return new List<IProduct>(AutoMapper.Mapper.Map<List<Product>>(Context.Products.Where(p => !p.IsDeleted)));
        }

        /// <summary>
        /// Removes from cart.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public bool RemoveFromCart(int productId)
        {
            return Context.Carts.FirstOrDefault().Items.Remove(Context.Products.First(p => p.Id.Equals(productId)));
        }

        #endregion Methods
    }
}