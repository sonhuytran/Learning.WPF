using System.Windows;

namespace Recipe_01_09
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Parent parent = new Parent();
            parent.PropertyThatInherits = "Still Inherits.";
            parent.PropertyThatDoesNotInherits = "Still Not Inheriting.";

            Child child = new Child();
            parent.Children.Add(child);

            this.DataContext = new object[]
            {
                parent,
                child
            };
        }
    }
}