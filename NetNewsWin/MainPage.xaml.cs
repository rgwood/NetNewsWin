using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NetNewsWin
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Feeds = Repository.GetTestFeeds();
            FeedsMDV.ItemsSource = Feeds;
        }

        public ObservableCollection<Feed> Feeds { get; set; }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EntriesView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //todo: error handling for deselection and possibly multiple items
            Entry selected = (Entry) (sender as MasterDetailsView).SelectedItem;
            if(selected != null)
            {
                selected.Unread = false;
            }
        }
    }


}
