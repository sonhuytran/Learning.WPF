using System;
using System.Windows;
using System.Windows.Controls;

namespace Recipe_03_21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            // Additional initializations
            this.Title = Application.ResourceAssembly.GetName().Name;
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            if (!(sender is TreeViewItem))
            {
                return;
            }

            string message = string.Empty;
            TreeViewItem selectedItem = sender as TreeViewItem;

            if (selectedItem == e.OriginalSource)
            {
                message = String.Format("Item selected: {0} ({1} child items)",
                    selectedItem.Header, selectedItem.Items.Count);
            }
            else
            {
                message = String.Format("Parent of item selected: {0} ({1} child items)",
                    selectedItem.Header, selectedItem.Items.Count);
            }

            this.tbkStatus.Text = message;
        }

        private void btnShowSelected_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem selectedItem = this.tvTree.SelectedItem as TreeViewItem;
            string message = string.Empty;

            if (null == selectedItem)
            {
                message = "No item selected";
            }
            else
            {
                message = string.Format("Selected item: {0}",
                    selectedItem.Header);
            }

            MessageBox.Show(message, this.Title);
        }
    }
}
