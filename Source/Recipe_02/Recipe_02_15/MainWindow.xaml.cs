using System.Windows;

namespace Recipe_02_15
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

        private void miClear_Click(object sender, RoutedEventArgs e)
        {
            this.txtTextBox.Clear();
        }

        private void miTextStyles_Click(object sender, RoutedEventArgs e)
        {
            if (this.miNormal == sender)
            {
                this.txtTextBox.FontWeight = FontWeights.Normal;
                this.txtTextBox.FontStyle = FontStyles.Normal;
            }
            else if (this.miBold == sender)
            {
                this.txtTextBox.FontWeight = FontWeights.Bold;
            }
            else if (this.miItalic == sender)
            {
                this.txtTextBox.FontStyle = FontStyles.Italic;
            }
        }
    }
}
