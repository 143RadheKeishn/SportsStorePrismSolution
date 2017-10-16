using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using SportsStorePrism.Module.ToolBar.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStorePrism.Infrastructure;

namespace SportsStorePrism.Module.ToolBar
{
   public class ToolBarModule:IModule
   {
      private IUnityContainer _container;
      private IRegionManager _regionManager;

      public void Initialize()
      {
         var toolBarView = _container.Resolve<ToolBarView>();
         _regionManager.Regions[RegionNames.ToolBarRegion].Add(toolBarView);
      }

      public ToolBarModule(IUnityContainer container, IRegionManager regionManager)
      {
         _container = container;
         _regionManager = regionManager;
      }
   }
}
