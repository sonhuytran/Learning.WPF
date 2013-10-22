using System.Windows;

namespace Recipe_03_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            this.sldr.Value--;
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            this.sldr.Value++;
        }
    }
}
