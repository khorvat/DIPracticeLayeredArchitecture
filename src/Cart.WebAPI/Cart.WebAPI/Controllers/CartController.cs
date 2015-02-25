using Cart.Model.Common;
using Cart.Service.Common;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cart.WebAPI.Controllers
{
    [RoutePrefix("api/cart")]
    public class CartController : ApiController
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CartController" /> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public CartController(ICartService service)
        {
            this.Service = service;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <value>The service.</value>
        protected ICartService Service { get; private set; }

        #endregion Properties

        #region Methods

        [HttpDelete]
        [Route("my-cart/products/{id}")]
        public bool DeleteMyCartProductsAsync(int id)
        {
            return Service.RemoveFromCart(id);
        }

        [HttpGet]
        [Route("products")]
        public List<IProduct> GetAsync()
        {
            return Service.GetAllAvailableProducts();
        }

        [HttpGet]
        [Route("my-cart")]
        public ICart GetMyCartAsync()
        {
            return Service.GetMyCart();
        }

        [HttpGet]
        [Route("my-cart/products")]
        public List<IProduct> GetMyCartProductsAsync()
        {
            return Service.GetMyCart().Items;
        }

        [HttpPost]
        [Route("my-cart/products/{id}")]
        public HttpResponseMessage PostMyCartProductsAsync(int id)
        {
            try
            {
                return Request.CreateResponse<bool>(Service.AddToCart(id));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Item is Out of Stock.");
            }
        }

        #endregion Methods
    }
}