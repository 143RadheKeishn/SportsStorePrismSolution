using Microsoft.Practices.Unity;
using Prism.Modularity;
using SportsStorePrism.Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStorePrism.Module.Services
{
   public class ServicesModule : IModule
   {
      public void Initialize()
      {
         _unityContainer.RegisterType<IProductRepository, EfProfuctRepository>(new ContainerControlledLifetimeManager());
      }

      private IUnityContainer _unityContainer;

      public ServicesModule(IUnityContainer unityContainer)
      {
         _unityContainer = unityContainer;
      }
   }
}
