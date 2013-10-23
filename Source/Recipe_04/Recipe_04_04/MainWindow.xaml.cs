using System;
using System.Windows;

namespace Recipe_04_04
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
        }

        private void SearchControl_SearchChanged(object sender, SearchChangedEventArgs e)
        {
            MessageBox.Show(string.Format("New Search: {0}", e.SearchText),
                this.Title);
        }
    }
}
