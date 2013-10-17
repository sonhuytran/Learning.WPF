using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Recipe_01_05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = Application.ResourceAssembly.GetName().Name;

            MainWindow.DataContextProperty.OverrideMetadata(typeof(MainWindow),
                new FrameworkPropertyMetadata(100d,
                    new PropertyChangedCallback(MainWindow.DataContext_PropertyChanged)));
        }

        private static void DataContext_PropertyChanged(DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            string message = string.Format(
                "DataContext Changed.{0}{0}Old Value: {1}{0}New Value:{2}{0}",
                Environment.NewLine,
                e.OldValue,
                e.NewValue);

            MessageBox.Show(message, Application.ResourceAssembly.GetName().Name);
        }

        private void btnUpdateDataContext_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = this.tbxUserText.Text;
        }
    }
}
