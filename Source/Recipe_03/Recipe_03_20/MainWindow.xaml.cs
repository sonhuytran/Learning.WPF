using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

namespace Recipe_03_20
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (!this.IsInitialized)
            {
                return;
            }

            CheckBox checkBox = e.OriginalSource as CheckBox;

            if (null == checkBox)
            {
                return;
            }

            this.txblStatus.Text = checkBox.Name + " checked.";
        }

        private void CheckBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            if (!this.IsInitialized)
            {
                return;
            }

            CheckBox checkBox = e.OriginalSource as CheckBox;

            if (null == checkBox)
            {
                return;
            }

            this.txblStatus.Text = checkBox.Name + " indeterminated.";
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (!this.IsInitialized)
            {
                return;
            }

            CheckBox checkBox = e.OriginalSource as CheckBox;

            if (null == checkBox)
            {
                return;
            }

            this.txblStatus.Text = checkBox.Name + " unchecked.";
        }

        private void btnGetSelectedCheckBox_Click(object sender, RoutedEventArgs e)
        {
            this.lbxSelectedCheckBoxes.Items.Clear();
            IEnumerable<CheckBox> checkBoxes = this.spLayoutRoot.Children.OfType<CheckBox>();
            IEnumerable<CheckBox> selectedCheckBoxes =
                checkBoxes.Where(cb => cb.IsChecked == true);

            foreach (CheckBox checkBox in selectedCheckBoxes)
            {
                lbxSelectedCheckBoxes.Items.Add(checkBox.Name);
            }
        }
    }
}
