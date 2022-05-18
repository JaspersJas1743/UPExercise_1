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
    public static class Theme { public static bool isDarkTheme = false; }
    
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
            Application.Current.MainWindow.Title = "220_Смирнов_ПР№1";
        }

        private void Exit(object sender, RoutedEventArgs e) { Application.Current.Shutdown(); }

        private void Deact(object sender, RoutedEventArgs e) { Application.Current.MainWindow.WindowState = WindowState.Minimized; }
        
        private void ClickCone(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Cone()); }
        
        private void ClickSphere(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Sphere()); }
        
        private void Drag(object sender, RoutedEventArgs e) { MainWindow.MouseDrug(); }

        private void ClickTruncatedCone(object sender, RoutedEventArgs e) { NavigationService.Navigate(new TruncatedCone()); }
        
        private void ClickCylinder(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Cylinder()); }

        private void NewTheme(object sender, RoutedEventArgs e) { MainWindow.ResetTheme(); }
    }
}