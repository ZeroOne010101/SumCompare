using Avalonia.Controls;
using SumCompare.ViewModels;

namespace SumCompare.Views
{
    public partial class TextView : UserControl
    {
        public TextView()
        {
            InitializeComponent();
            DataContext = new TextViewModel();
        }
    }
}
