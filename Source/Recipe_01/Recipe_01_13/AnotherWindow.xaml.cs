using System.Windows;

namespace Recipe_01_13
{
    /// <summary>
    /// Interaction logic for AnotherWindow.xaml
    /// </summary>
    public partial class AnotherWindow : Window
    {
        public AnotherWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string propertyValue = ApplicationPropertiesHelper.GetProperty<string>("PropertyKey");

            if (string.IsNullOrEmpty(propertyValue))
            {
                propertyValue = "Nothing to display";
            }

            tbxUserText.Text = propertyValue;
        }
    }
}
