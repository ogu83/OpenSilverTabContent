using System;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilverTabContent
{
    public partial class MainPage : Page
    {
        private readonly TabItem _tabItem1;

        public MainPage()
        {
            this.InitializeComponent();

            // Enter construction logic here...
            _tabItem1 = new TabItem
            {
                Header = "Header",
                Content = "Initial Content"
            };

            MyTabControl.Items.Add(_tabItem1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _tabItem1.Content = new TextBlock { Text = "Changed Content at " + DateTime.Now.ToString("s") };
        }
    }
}
