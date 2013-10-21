using System;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace Recipe_02_13
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

        private void btnShowPopup_Click(object sender, EventArgs e)
        {
            if (this.btnFadePopup == sender)
            {
                this.popRecipe02_13.PopupAnimation = PopupAnimation.Fade;
            }
            else if (this.btnScrollPopup == sender)
            {
                this.popRecipe02_13.PopupAnimation = PopupAnimation.Scroll;
            }
            else if (this.btnSlidePopup == sender)
            {
                this.popRecipe02_13.PopupAnimation = PopupAnimation.Slide;
            }
            else
            {
                this.popRecipe02_13.PopupAnimation = PopupAnimation.None;
            }

            this.popRecipe02_13.IsOpen = false;
            this.popRecipe02_13.IsOpen = true;
        }

        private void btnClosePopup_Click(object sender, RoutedEventArgs e)
        {
            this.popRecipe02_13.IsOpen = false;
        }
    }
}
