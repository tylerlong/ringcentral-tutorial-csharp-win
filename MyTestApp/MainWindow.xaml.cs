using System.Diagnostics;
using System.Windows;

namespace MyTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RingCentral.SDK.Platform platform = null;

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
