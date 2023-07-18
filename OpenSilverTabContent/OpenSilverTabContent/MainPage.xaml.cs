using System;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilverTabContent
{
    public partial class MainPage : Page
    {
        TabControl _tabControl;
        TabItem _tabItem1;
        TabItem _tabItem2;

        public MainPage()
        {
            InitializeComponent();

            //_tabControl = new TabControl();

            //// Enter construction logic here...
            //_tabItem1 = new TabItem
            //{
            //    Header = "Header 1",
            //    Content = "Initial Content 1",
            //    Style = Resources["MainProcessStepStyle"] as Style
            //};

            //_tabItem2 = new TabItem
            //{
            //    Header = "Header 2",
            //    Content = "Initial Content 2",
            //    Style = Resources["MainProcessStepStyle"] as Style
            //};

            //_tabControl.Items.Add(_tabItem1);
            //_tabControl.Items.Add(_tabItem2);
            //_tabItem1.Content = new TextBlock { Text = "Changed Content at " + DateTime.Now.ToString("s") };

            //rootContainer.Children.Add(_tabControl);
        }

        private void TextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }
    }
}