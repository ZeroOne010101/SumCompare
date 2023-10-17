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
        public FileView(string[] arguments, int index)
        {
            InitializeComponent();
            DataContext = new FileViewModel(arguments, index);
        }
    }
}
