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

namespace CertView.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
#if !DUMMY
    private readonly IFilePickerService filePickerService = new FilePickerService();
    private readonly ICertificateReaderService certificateReaderService = new CertificateReaderService();
#else
    private readonly IFilePickerService filePickerService = new DummyPickerService();
    private readonly ICertificateReaderService certificateReaderService = new DummyReaderService();
#endif
    internal MainViewModel ViewModel { get;} 
    public MainWindow()
    {
        InitializeComponent();
        ViewModel = new MainViewModel(filePickerService,certificateReaderService);
        DataContext = ViewModel;
    }
}