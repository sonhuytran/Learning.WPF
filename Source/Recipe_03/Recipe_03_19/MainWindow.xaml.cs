using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

namespace Recipe_03_19
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

        private void rbn2A_Checked(object sender, RoutedEventArgs e)
        {
            if (!this.IsInitialized)
            {
                return;
            }

            try
            {
                RadioButton radioButton = e.OriginalSource as RadioButton;

                if (null == radioButton)
                {
                    return;
                }

                MessageBox.Show(radioButton.Content + " checked.",
                    this.Title);
            }
            catch
            {
                //
            }
        }

        private void btnShowGroup1Selection_Click(object sender, RoutedEventArgs e)
        {
            RadioButton selectedButton = null;

            try
            {
                selectedButton = this.GetCheckedRadioButton(this.spLeftContainer.Children,
                    "Group1");
            }
            catch
            {

            }

            if (null == selectedButton)
            {
                try
                {
                    selectedButton = this.GetCheckedRadioButton(this.spRightContainter.Children,
                        "Group1");
                }
                catch
                {

                }
            }

            if (null == selectedButton)
            {
                return;
            }

            MessageBox.Show(selectedButton.Content + " checked.",
                this.Title);
        }

        private RadioButton GetCheckedRadioButton(UIElementCollection children, string groupName)
        {
            IEnumerable<RadioButton> radioButtons = children.OfType<RadioButton>();

            return radioButtons.FirstOrDefault<RadioButton>(
                rb => rb.IsChecked.Equals(true)
                    && rb.GroupName.Equals(groupName));
        }
    }
}