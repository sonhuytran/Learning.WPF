using System.Windows;

namespace Recipe_05_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new Person()
            {
                FirstName = "Phil",
                LastName = "Jones",
                Age = 20,
                Occupation = "Red Devil"
            };
        }
    }
}
