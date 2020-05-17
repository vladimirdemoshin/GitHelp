using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Desktop.ViewModels;
using Desktop.Views;
using ReactiveUI;

namespace Desktop.Windows
{
    public class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        private StartView _startView;

        public MainWindow()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            this.WhenActivated(disposables => {
                _startView = this.FindControl<StartView>("StartView");
                var mainWindowViewModel = DataContext as MainWindowViewModel;
                var startViewModel = new StartViewModel(mainWindowViewModel);
                _startView.DataContext = startViewModel;
            });
            AvaloniaXamlLoader.Load(this);
        }
    }
}
