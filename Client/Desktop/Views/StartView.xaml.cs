using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Desktop.Views
{
    public class StartView : UserControl
    {
        public StartView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
