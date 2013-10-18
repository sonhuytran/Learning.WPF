using System.Windows;

namespace Recipe_01_08
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

        private void uiElement_Click(object sender, RoutedEventArgs e)
        {
            UIElement element = sender as UIElement;
            MessageBox.Show("Rotation = " + GetRotation(element),
                Application.ResourceAssembly.GetName().Name);
        }

        #region Rotation Attached Dependency Property

        public static readonly DependencyProperty RotationProperty =
            DependencyProperty.RegisterAttached("Rotation", typeof(double), typeof(MainWindow),
                new FrameworkPropertyMetadata(0d,
                    FrameworkPropertyMetadataOptions.AffectsRender));

        public static void SetRotation(UIElement element, double value)
        {
            element.SetValue(MainWindow.RotationProperty, value);
        }

        public static double GetRotation(UIElement element)
        {
            return (double)element.GetValue(MainWindow.RotationProperty);
        }

        #endregion Rotation Attached Dependency Property

        private void ListView_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }
    }
}
