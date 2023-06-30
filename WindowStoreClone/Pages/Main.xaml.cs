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
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;
        public Main()
        {
            InitializeComponent();

            DealsAppsViewer.AppClicked += AnAppCliked;

            GamingViewer.AppClicked += AnAppCliked;
            EntertainmentViewer.AppClicked += AnAppCliked;

            FeaturedAppsViewer.AppClicked += AnAppCliked;
            TopAppsViewer.AppClicked += AnAppCliked;
            TopGamesViewer.AppClicked += AnAppCliked;
            CollectionsViewer.AppClicked += AnAppCliked;
        }

        private void AnAppCliked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }
    }
}
