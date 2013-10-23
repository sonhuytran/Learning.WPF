using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Recipe_04_04
{
    /// <summary>
    /// Interaction logic for SearchControl.xaml
    /// </summary>
    public partial class SearchControl : UserControl
    {
        public SearchControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            this.OnSearchChanged();
        }

        private void OnSearchChanged()
        {
            SearchChangedEventArgs e = new SearchChangedEventArgs(
                this.txtSearch.Text);
            e.RoutedEvent = SearchChangedEvent;
            this.RaiseEvent(e);
        }

        #region SearchChanged RoutedEvent

        public delegate void SearchChangedEventHandler(object sender,
            SearchChangedEventArgs e);

        public static RoutedEvent SearchChangedEvent =
            EventManager.RegisterRoutedEvent("SearchChanged", RoutingStrategy.Bubble,
                typeof(SearchChangedEventHandler), typeof(SearchControl));

        public event SearchChangedEventHandler SearchChanged
        {
            add
            {
                this.AddHandler(SearchChangedEvent, value);
            }

            remove
            {
                this.RemoveHandler(SearchChangedEvent, value);
            }
        }

        #endregion SearchChanged RoutedEvent

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.OnSearchChanged();
            }
        }
    }

    public class SearchChangedEventArgs : RoutedEventArgs
    {
        private readonly string searchText;

        public string SearchText
        {
            get
            {
                return searchText;
            }
        }

        public SearchChangedEventArgs(string searchText)
        {
            this.searchText = searchText;
        }
    }
}
