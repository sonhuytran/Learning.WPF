using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace Recipe_01_08
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UserControl1 control = sender as UserControl1;
            MessageBox.Show("Rotation = " + MainWindow.GetRotation(control),
                Application.ResourceAssembly.GetName().Name);
        }
    }
}
