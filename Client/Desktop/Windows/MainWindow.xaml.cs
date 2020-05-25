using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Desktop.ViewModels;
using Desktop.Views;
using Domain.API;
using Infrastructure;
using ReactiveUI;
using Splat;
using Unity;

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
                var gitFacade = IoC.Container.Resolve<IGitFacade>();
                var startViewModel = new StartViewModel(mainWindowViewModel);
                startViewModel.GitFacade = gitFacade;
                _startView.DataContext = startViewModel;
            });
            AvaloniaXamlLoader.Load(this);
        }
    }
}
