using System.Windows;

namespace Recipe_01_13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            (new AnotherWindow()).ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ApplicationPropertiesHelper.SetProperty("PropertyKey", tbxUserText.Text);
            (new AnotherWindow()).ShowDialog();
        }
    }
}
