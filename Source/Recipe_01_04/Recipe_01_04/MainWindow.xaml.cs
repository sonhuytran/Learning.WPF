using System.Windows;
using System.Windows.Threading;
using System;

namespace Recipe_01_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer =
                new DispatcherTimer(TimeSpan.FromSeconds(1),
                    DispatcherPriority.Normal, this.dispatcherTimer_Tick, this.Dispatcher);
        }

        #region Counter Dependency Property [read-only]

        private static readonly DependencyPropertyKey counterPropertyKey =
            DependencyProperty.RegisterReadOnly("Counter", typeof(int), typeof(MainWindow),
                new PropertyMetadata(0));

        public int Counter
        {
            get
            {
                return (int)this.GetValue(MainWindow.counterPropertyKey.DependencyProperty);
            }
        }

        #endregion Counter Dependency Property [read-only]

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            // Increment the value stored in counter
            int newValue = (this.Counter >= int.MaxValue) ? 0 : this.Counter + 1;

            // Uses the SetValue that accepts a DependencyPropertyKey
            this.SetValue(MainWindow.counterPropertyKey, newValue);
        }
    }
}