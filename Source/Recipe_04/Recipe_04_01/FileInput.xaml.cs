using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using System.Windows.Markup;

namespace Recipe_04_01
{
    /// <summary>
    /// Interaction logic for FileInput.xaml
    /// </summary>
    [ContentProperty("SelectedFileName")]
    public partial class FileInput : UserControl
    {
        public FileInput()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();

            if (openFileDlg.ShowDialog() == true)
            {
                this.SelectedFileName = openFileDlg.FileName;
            }
        }

        #region SelectedFileName Dependency Property

        public static DependencyProperty SelectedFileNameProperty =
            DependencyProperty.Register("SelectedFileName", typeof(string), typeof(FileInput),
                new FrameworkPropertyMetadata(null));

        public string SelectedFileName
        {
            get
            {
                return this.GetValue(SelectedFileNameProperty) as string;
            }

            set
            {
                this.SetValue(SelectedFileNameProperty, value);
            }
        }
        
        #endregion SelectedFileName Dependency Property
    }
}
