using Desktop.ViewModels;
using Desktop.Views;
using Domain.API;
using Domain.Shared.API;
using Infrastructure;
using ReactiveUI;
using Splat;
using Unity;
using Unity.Lifetime;

namespace Desktop
{
    public static class Registry
    {
        public static void Initialize()
        {
            InitializeLocator();
            InitializeUnity();
        }

        private static void InitializeLocator()
        {
            Locator.CurrentMutable.Register(() => new RepositoryView(), typeof(IViewFor<RepositoryViewModel>));
        }

        private static void InitializeUnity()
        {
            IoC.Container.RegisterType<IGitFacade, GitFacade>(new ContainerControlledLifetimeManager());
        }
    }
}
