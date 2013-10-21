using System.Windows;

namespace Recipe_02_12
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

        private void btnMessageOnly_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A Simple MessageBox");
        }

        private void btnMessageHeader_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A MessageBox with a Title",
                Application.ResourceAssembly.GetName().Name);
        }

        private void btnMessageHeaderButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A MessageBox with a Title and Buttons",
                Application.ResourceAssembly.GetName().Name,
                MessageBoxButton.YesNoCancel);
        }

        private void BtnMessageHeaderButtonImage_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A MessageBox with a Title, Buttons, and an Icon",
                 Application.ResourceAssembly.GetName().Name,
                MessageBoxButton.YesNoCancel,
                MessageBoxImage.Question);
        }
    }
}
