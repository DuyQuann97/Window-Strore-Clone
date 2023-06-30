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
using WindowStoreClone.UserControls;

namespace WindowStoreClone.Pages
{
    /// <summary>
    /// Interaction logic for AppDetailsPage.xaml
    /// </summary>
    public partial class AppDetailsPage : Page
    {
        public delegate void OnBackButtonClicked(object sender, RoutedEventArgs e);
        public event OnBackButtonClicked BackButtonClicked;
        public AppDetailsPage(AnApp inApp)
        {
            InitializeComponent();
            AppDetailTitleAndBackGroundUC.AppLabelName.Content = inApp.AppName;
            AppDetailTitleAndBackGroundUC.AppImage.Source = inApp.AppImageSource;
            AppDetailTitleAndBackGroundUC.BackButtonClicked += AppDetailTitleAndBackGroundUC_BackButtonCliked;
        }

        private void AppDetailTitleAndBackGroundUC_BackButtonCliked(object sender, RoutedEventArgs e)
        {
            BackButtonClicked(sender, e);
        }
    }
}
