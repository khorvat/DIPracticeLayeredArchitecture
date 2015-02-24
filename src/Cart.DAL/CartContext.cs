using System;
using System.Collections.Generic;

namespace Cart.DAL
{
    public class CartContext : ICartContext
    {
        #region Constructors

        public CartContext()
        {
            Carts = new List<CartEntity>() {
                new CartEntity()
                {
                    Id = 1,
                    Items = new List<ProductEntity>()
                }
            };
            Products = new List<ProductEntity>()
            {
                new ProductEntity() {
                    Id = 1,
                    Name = "Product 1",
                    Description = "Product 1 that everyone needs",
                    Price = 1000,
                    InStock = true
                },
                new ProductEntity() {
                    Id = 2,
                    Name = "Product 2",
                    Description = "Product 2 that everyone needs",
                    Price = 2000,
                    InStock = true
                },
                new ProductEntity() {
                    Id = 3,
                    Name = "Product 3",
                    Description = "Product 3 that everyone needs",
                    Price = 3000,
                    InStock = true
                },
                new ProductEntity() {
                    Id = 4,
                    Name = "Product 4",
                    Description = "Product 4 that everyone needs",
                    Price = 4000,
                    InStock = false
                }
                ,
                new ProductEntity() {
                    Id = 5,
                    Name = "Product 5",
                    Description = "Product 5 that everyone needs",
                    Price = 5000,
                    InStock = true,
                    IsDeleted = true
                },
                new ProductEntity() {
                    Id = 6,
                    Name = "Product 6",
                    Description = "Product 6 that everyone needs",
                    Price = 6000,
                    InStock = true,
                    IsDeleted = true
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