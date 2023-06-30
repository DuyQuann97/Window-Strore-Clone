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
        public event OnAppClicked AppCliked;
        public Main()
        {
            InitializeComponent();

            DealsAppsViewer.AppCliked += AnAppCliked;

            GamingViewer.AppCliked += AnAppCliked;
            EntertainmentViewer.AppCliked += AnAppCliked;

            FeaturedAppsViewer.AppCliked += AnAppCliked;
            TopAppsViewer.AppCliked += AnAppCliked;
            TopGamesViewer.AppCliked += AnAppCliked;
            CollectionsViewer.AppCliked += AnAppCliked;
        }

        private void AnAppCliked(AnApp sender, RoutedEventArgs e)
        {
            AppCliked(sender, e);
        }
    }
}
