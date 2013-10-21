using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Recipe_01_15
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
            Brush[] backgrounds = new Brush[5]
            {
                Brushes.Red,
                Brushes.Blue,
                Brushes.Green,
                Brushes.Yellow,
                Brushes.HotPink
            };

            for (int i = 0; i < 5; i++)
            {
                Window window = new Window();
                this.SetupWindow(window, "Window " + (i + 1), backgrounds[i]);
                window.Show();
            }

            this.RebuildWindowList();
        }

        private void Window_Closing_1(object sender, CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void SetupWindow(Window window, string title, Brush background)
        {
            if (null == window)
            {
                return;
            }

            window.Closing += new CancelEventHandler(this.Window_Closing);
            window.Closed += new EventHandler(this.Window_Closed);
            
            window.Background = background;
            window.Title = title;
            window.Height = 100d;
            window.Width = 100d;

            Viewbox viewbox = new Viewbox();
            TextBlock textBlock = new TextBlock();
            textBlock.Text = title;
            viewbox.Child = textBlock;
            window.Content = viewbox;
        }

        private Window SelectedWindow
        {
            get
            {
                return this.lbxWindows.SelectedItem as Window;
            }
        }

        private void RebuildWindowList()
        {
            List<Window> windows = new List<Window>();

            foreach (Window window in Application.Current.Windows)
            {
                if (this != window)
                {
                    windows.Add(window);
                }
            }

            lbxWindows.ItemsSource = windows;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.RebuildWindowList();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Window window = sender as Window;

            if (null == window)
            {
                return;
            }

            e.Cancel = !(cbxCanClose.IsChecked == true);
        }

        private void cbxIsVisible_Checked(object sender, RoutedEventArgs e)
        {
            Window window = this.SelectedWindow;

            if (null == window)
            {
                return;
            }

            window.Show();
        }

        private void cbxIsVisible_Unchecked(object sender, RoutedEventArgs e)
        {
            Window window = this.SelectedWindow;

            if (null == window)
            {
                return;
            }

            window.Hide();
        }

        private void btnBringToFront_Click(object sender, RoutedEventArgs e)
        {
            Window window = this.SelectedWindow;

            if (null == window)
            {
                return;
            }

            window.Activate();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Window window = this.SelectedWindow;

            if (null == window)
            {
                return;
            }

            window.Close();
        }
    }
}