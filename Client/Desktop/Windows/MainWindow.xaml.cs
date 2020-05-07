using Avalonia;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Desktop.ViewModels;
using ReactiveUI;

namespace Desktop.Windows
{
    public class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            this.WhenActivated(disposables => { });
            AvaloniaXamlLoader.Load(this);
        }
    }
}
