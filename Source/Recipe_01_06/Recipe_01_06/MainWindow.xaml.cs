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
using System.ComponentModel;

namespace Recipe_01_06
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
            DependencyPropertyDescriptor descriptor = DependencyPropertyDescriptor.FromProperty(
                TextBox.TextProperty, typeof(TextBox));
            descriptor.AddValueChanged(this.tbxEditMe, this.tbxEditMe_TextChanged);
        }

        private void tbxEditMe_TextChanged(object sender, EventArgs e)
        {
            this.tblkTextValue.Text = (sender as TextBox).Text;
        }
    }
}
