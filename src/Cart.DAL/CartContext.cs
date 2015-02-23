using System;
using System.Collections.Generic;

namespace Cart.DAL
{
    public class CartContext : ICartContext
    {
        #region Constructors

        public CartContext()
        {
            Carts = new List<CartEntity>();
            Products = new List<ProductEntity>()
            {
                new ProductEntity() {
                    Id = Guid.NewGuid(),
                    Name = "Product 1",
                    Description = "Product 1 that everyone needs",
                    Price = 1000,
                    InStock = true
                },
                new ProductEntity() {
                    Id = Guid.NewGuid(),
                    Name = "Product 2",
                    Description = "Product 2 that everyone needs",
                    Price = 2000,
                    InStock = true
                },
                new ProductEntity() {
                    Id = Guid.NewGuid(),
                    Name = "Product 3",
                    Description = "Product 3 that everyone needs",
                    Price = 3000,
                    InStock = true
                },
                new ProductEntity() {
                    Id = Guid.NewGuid(),
                    Name = "Product 4",
                    Description = "Product 4 that everyone needs",
                    Price = 4000,
                    InStock = false
                }
            };
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the carts.
        /// </summary>
        /// <value>The carts.</value>
        public List<CartEntity> Carts { get; set; }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>The products.</value>
        public List<ProductEntity> Products { get; set; }

        #endregion Properties
    }
}