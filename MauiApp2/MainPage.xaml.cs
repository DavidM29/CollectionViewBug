using System.Collections.ObjectModel;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        private readonly ObservableCollection<string> _items = ["Item 1", "Item 2", "Item 3"];

        public MainPage()
        {
            InitializeComponent();

            CollectionView1.ItemsSource = _items;
            CollectionView2.ItemsSource = _items;
        }
    }

}
