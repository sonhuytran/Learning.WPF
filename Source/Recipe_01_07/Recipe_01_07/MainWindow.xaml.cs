using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Recipe_01_07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void tbxUserValue_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (null != textBox)
            {
                textBox.Foreground = Brushes.Firebrick;
            }
        }

        #region UserValue Dependency Property

        public static readonly DependencyProperty UserValueProperty =
            DependencyProperty.Register("UserValue", typeof(int), typeof(MainWindow),
                new PropertyMetadata(1,
                    new PropertyChangedCallback(MainWindow.UserValue_PropertyChangedCallback)),
                new ValidateValueCallback(MainWindow.UserValue_ValidationValueCallback));

        public int UserValue
        {
            get
            {
                return (int)this.GetValue(MainWindow.UserValueProperty);
            }

            set
            {
                this.SetValue(MainWindow.UserValueProperty, value);
            }
        }

        private static bool UserValue_ValidationValueCallback(object value)
        {
            int intValue;

            if (int.TryParse(value.ToString(), out intValue))
            {
                if (intValue >= 1 && intValue <= 100)
                {
                    return true;
                }
            }

            return false;
        }

        private static void UserValue_PropertyChangedCallback(DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            MainWindow window = d as MainWindow;

            if (null != window)
            {
                window.tbxUserValue.Foreground = Brushes.SeaGreen;
            }
        }

        #endregion UserValue Dependency Property
    }
}
