using Autofac;
using BusinessLogicLayer.Abstract;
using BusinessLogicLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

        }
    }
}
