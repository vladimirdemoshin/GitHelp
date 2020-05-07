using ReactiveUI;
using System.Reactive;

namespace Desktop.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, IScreen
    {
        public RoutingState Router { get; } = new RoutingState();
        public ReactiveCommand<Unit, IRoutableViewModel> NavigateToRepositoryViewCommand { get; protected set; }
        public ReactiveCommand<Unit, Unit> NavigateBack { get; protected set; }

        public MainWindowViewModel()
        {
            NavigateBack = Router.NavigateBack;
            NavigateToRepositoryViewCommand = ReactiveCommand.CreateFromObservable(
                () => Router.Navigate.Execute(new RepositoryViewModel(this))
            );
        }

    }
}
