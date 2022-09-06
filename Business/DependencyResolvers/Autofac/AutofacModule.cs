using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Security.JWT;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EF.MainDB;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {s
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDAL>();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
                        
        }
    }
}