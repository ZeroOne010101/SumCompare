using Avalonia.Controls;
using SumCompare.ViewModels;

namespace SumCompare.Views
{
    public partial class FileView : UserControl
    {
        public FileView()
        {
            InitializeComponent();
            DataContext = new FileViewModel();
        }

        public FileView(int index)
        {
            InitializeComponent();
            DataContext = new FileViewModel(index);
        }
    }
}
