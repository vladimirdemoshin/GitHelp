using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Desktop.ViewModels;
using ReactiveUI;

namespace Desktop.Views
{
    public class RepositoryView : ReactiveUserControl<RepositoryViewModel>
    {
        public RepositoryView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.WhenActivated(disposables => { });
            AvaloniaXamlLoader.Load(this);
        }
    }
}
