using ReactiveUI;

namespace Desktop.ViewModels
{
    public class RepositoryViewModel : ViewModelBase, IRoutableViewModel
    {
        public IScreen HostScreen { get; }
        public string UrlPathSegment => throw new System.NotImplementedException();

        public RepositoryViewModel(IScreen screen)
        {
            HostScreen = screen;
        }
    }
}
