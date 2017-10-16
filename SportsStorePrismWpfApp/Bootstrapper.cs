
using System.Windows;
using Prism.Modularity;
using Prism.Unity;
using SportsStorePrism.Module.ToolBar;
using SportsStorePrism.Module.Services;

namespace SportsStorePrismWpfApp
{
   public class Bootstrapper:UnityBootstrapper
   {
      protected override DependencyObject CreateShell()
      {
         return Container.TryResolve<Shell>();

         #region Default
         //return base.CreateShell(); 
         #endregion
      }

      protected override void InitializeShell()
      {
         base.InitializeShell();
         App.Current.MainWindow = Shell as Window;
         App.Current.MainWindow.Show();
      }
      protected override IModuleCatalog CreateModuleCatalog()
      {
         //return base.CreateModuleCatalog();
         ModuleCatalog moduleCatalog = new ModuleCatalog();
         moduleCatalog.AddModule(typeof(ToolBarModule));
         moduleCatalog.AddModule(typeof(ServicesModule));
         return moduleCatalog;
      }
   }
}
