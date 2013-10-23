using System.Windows;
using System.Windows.Controls;

namespace Recipe_03_22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Additional initialization
            this.Title = Application.ResourceAssembly.GetName().Name;
        }

        private void outerListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = this.outerListBox.SelectedItem;
            string message = string.Empty;

            if (null == selectedItem)
            {
                message = "No item currently selected.";
            }
            else
            {
                message = string.Format("{0} is selected.",
                    selectedItem);
            }

            this.tbkStatus.Text = message;
        }

        private void innerListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            if (null == sender
                || !(sender is ListBoxItem))
            {
                return;
            }

            ListBoxItem selectedItem = sender as ListBoxItem;
            string message = string.Format("{0} is selected.",
                selectedItem.Content);
            MessageBox.Show(message, this.Title);
        }
    }
}
