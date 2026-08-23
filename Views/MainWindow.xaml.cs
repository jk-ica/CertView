using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CertView.ViewModels;
using CertView.Services;

namespace CertView.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal MainViewModel ViewModel { get; set; } = new MainViewModel(new DummyPickerService(), new DummyReaderService());
        public MainWindow()
        {
            InitializeComponent();
            DataContext = ViewModel;
        }
    }
}