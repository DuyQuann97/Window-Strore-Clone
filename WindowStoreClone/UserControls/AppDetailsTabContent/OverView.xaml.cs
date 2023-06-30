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

namespace WindowStoreClone.UserControls.AppDetailsTabContent
{
    
    /// <summary>
    /// Interaction logic for OverView.xaml
    /// </summary>
    public partial class OverView : UserControl
    {
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;
        public OverView()
        {
            InitializeComponent();
            AppsViewerInsideOwerViewTab.AppClicked += AppsViewerInsideOwerViewTab_AppClicked;
        }

        private void AppsViewerInsideOwerViewTab_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }
    }
}
