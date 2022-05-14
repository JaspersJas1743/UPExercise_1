using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace Задание__1
{
    public partial class Menu : Page
    {
        public Menu() { InitializeComponent(); }

        private void ClickCone(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Cone()); }
        private void ClickSphere(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Sphere()); }
        private void ClickTruncatedCone(object sender, RoutedEventArgs e) { NavigationService.Navigate(new TruncatedCone()); }
        private void ClickCylinder(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Cylinder()); }
    }
}