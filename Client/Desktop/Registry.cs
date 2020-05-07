using Desktop.ViewModels;
using Desktop.Views;
using ReactiveUI;
using Splat;

namespace Desktop
{
    public static class Registry
    {
        public static void Initialize()
        {
            Locator.CurrentMutable.Register(() => new RepositoryView(), typeof(IViewFor<RepositoryViewModel>));
        }
    }
}
