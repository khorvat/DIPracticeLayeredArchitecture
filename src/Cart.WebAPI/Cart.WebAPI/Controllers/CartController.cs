using Cart.Model.Common;
using Cart.Service.Common;
using System;
using System.Collections.Generic;
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

        #endregion Methods
    }
}