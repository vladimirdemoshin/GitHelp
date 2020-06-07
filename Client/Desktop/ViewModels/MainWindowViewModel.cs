using ReactiveUI;

namespace Desktop.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, IScreen
    {
        public RoutingState Router { get; } = new RoutingState();
        public string MenuTitle { get; set; }

        public MainWindowViewModel()
        {
            MenuTitle = "GitHelp";
        }
    }
}
