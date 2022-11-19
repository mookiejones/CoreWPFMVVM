using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;
using CoreWPFMVVM.ViewModels;

namespace CoreWPFMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = Ioc.Default.GetRequiredService<WorkspaceViewModel>();
        }
    }
}
