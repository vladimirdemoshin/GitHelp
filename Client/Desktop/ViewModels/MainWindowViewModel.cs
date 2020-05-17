using ReactiveUI;

namespace Desktop.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, IScreen
    {
        public RoutingState Router { get; } = new RoutingState();

        public MainWindowViewModel()
        {
        }
    }
}
