using Cart.Common;
using Ninject.Extensions.Interception;
using System;

namespace Cart.WebAPI
{
    public class GreedyInterceptor : ICartInterceptor
    {
        #region Methods

        public void Intercept(IInvocation invocation)
        {
            if (invocation.Request.Method.Name.Equals("RemoveFromCart"))
            {
                invocation.ReturnValue = false;
                return;
            }
            invocation.Proceed();
        }

        #endregion Methods
    }
}