using Cart.DAL;
using Cart.Model;
using Cart.Model.Common;
using Cart.Repository.Common;
using System;

namespace Cart.Repository
{
    public class DIModule : Ninject.Modules.NinjectModule
    {
        #region Methods

        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            AutoMapper.Mapper.CreateMap<ProductEntity, Product>().ReverseMap();
            AutoMapper.Mapper.CreateMap<ProductEntity, IProduct>().ReverseMap();
            AutoMapper.Mapper.CreateMap<IProduct, Product>().ReverseMap();
            AutoMapper.Mapper.CreateMap<CartEntity, Cart.Model.Cart>().ReverseMap();
            AutoMapper.Mapper.CreateMap<CartEntity, ICart>().ReverseMap();
            AutoMapper.Mapper.CreateMap<ICart, Cart.Model.Cart>().ReverseMap();

            //Note: Our fake context will act as database
            Bind<ICartContext>().To<CartContext>().InSingletonScope();
            Bind<ICartRepository>().To<CartRepository>();
        }

        #endregion Methods
    }
}