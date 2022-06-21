using System;
using System.Windows.Controls;

namespace OpenSilverTabContent
{
    public partial class MainPage : Page
    {
        TabControl _tabControl;
        TabItem _tabItem1;

        public MainPage()
        {
             InitializeComponent();

            _tabControl = new TabControl();

            // Enter construction logic here...
            _tabItem1 = new TabItem
            {
                Header = "Header",
                Content = "Initial Content"
            };

            _tabControl.Items.Add(_tabItem1);

            _tabItem1.Content = new TextBlock { Text = "Changed Content at " + DateTime.Now.ToString("s") };

            rootContainer.Children.Add(_tabControl);
        }
    }
}