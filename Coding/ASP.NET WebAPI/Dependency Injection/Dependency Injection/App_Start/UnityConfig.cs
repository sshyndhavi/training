using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using static Dependency_Injection.Repository.UserRepo;

namespace Dependency_Injection
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUserMasterRepository, UserMasterRepository>();
               

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}