using Avalonia.Controls;
using SumCompare.ViewModels;

namespace SumCompare.Views
{
    public partial class AboutView : UserControl
    {
        public AboutView()
        {
            InitializeComponent();
            DataContext = new AboutViewModel();
        }
    }
}
