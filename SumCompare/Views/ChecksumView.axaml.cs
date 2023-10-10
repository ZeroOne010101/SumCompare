using Avalonia.Controls;
using SumCompare.ViewModels;

namespace SumCompare.Views
{
    public partial class ChecksumView : UserControl
    {
        public ChecksumView()
        {
            InitializeComponent();
            DataContext = new ChecksumViewModel();
        }
    }
}
