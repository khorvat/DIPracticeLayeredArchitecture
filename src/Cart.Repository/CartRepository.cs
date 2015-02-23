using Cart.DAL;
using Cart.Model;
using Cart.Model.Common;
using Cart.Repository.Common;
using System;
using System.Collections.Generic;

namespace Cart.Repository
{
    public class CartRepository : ICartRepository
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CartRepository" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public CartRepository(ICartContext context)
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
            return new List<IProduct>(AutoMapper.Mapper.Map<List<Product>>(Context.Products));
        }

        #endregion Methods
    }
}