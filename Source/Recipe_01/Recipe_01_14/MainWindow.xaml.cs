using System;
using System.Diagnostics;
using System.Windows;

namespace Recipe_01_14
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

        private void btnCreateNewInstance_Click(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = string.Format(@"{0}\{1}",
                Environment.CurrentDirectory,
                Application.ResourceAssembly.GetName().Name);
            process.StartInfo.Arguments = tbxArgs.Text;

            process.Start();
        }
    }
}
