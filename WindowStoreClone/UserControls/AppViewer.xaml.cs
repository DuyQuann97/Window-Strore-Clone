using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowStoreClone.UserControls
{
    /// <summary>
    /// Interaction logic for AppViewer.xaml
    /// </summary>
    public partial class AppViewer : UserControl
    {
        List<AnApp> PresentApps;
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;
        public AppViewer()
        {
            InitializeComponent();
            PresentApps = new List<AnApp>();
            AppList.ItemsSource = PresentApps;
            for(int i = 0; i < 9; i++) 
            {
                AnApp currApp = new AnApp();
                currApp.AppCliked += Curr_AppClicked;
                PresentApps.Add(currApp);
            } 
        }

        private void Curr_AppClicked(AnApp sender, RoutedEventArgs e) 
        {
            AppClicked(sender, e);
        }

        private void ScrollLeftButton_Click(object sender, RoutedEventArgs e)
        {
            int widthOfApp = (int)PresentApps.First().ActualWidth + 2 * (int)PresentApps.First().Margin.Left;
            AppScrollView.ScrollToHorizontalOffset(AppScrollView.HorizontalOffset - 4 * widthOfApp);
        }

        private void ScrollRightButton_Click(object sender, RoutedEventArgs e)
        {
            int widthOfApp = (int)PresentApps.First().ActualWidth + 2 * (int)PresentApps.First().Margin.Left;
            AppScrollView.ScrollToHorizontalOffset(AppScrollView.HorizontalOffset + 4 * widthOfApp);
        }
    }
}
