using Castle.Core.Interceptor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterceptors:MethodInterceptionBaseAttribute
    {
        //Method çalışmadan önce çalışır, Invocation çalıştırılmaya çalışan method
        protected virtual void OnBefore(IInvocation ınvocation)
        {

        }
        protected virtual void OnAfter(IInvocation ınvocation)
        {

        }
        protected virtual void OnException(IInvocation ınvocation)
        {

        }
        protected virtual void OnSuccess(IInvocation ınvocation)
        {

        }
        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception)
            {

                isSuccess = false;
                OnException(invocation);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
                else
                {
                    OnAfter(invocation);
                }
            }
        }
    }
}
