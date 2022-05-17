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
    public partial class TruncatedCone : Page
    {
        public TruncatedCone()
        {
            InitializeComponent();
            RadiusMinBox.Focus();
        }

        private void BackButtonTruncatedCone(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Menu()); }
        
        private void Exit(object sender, RoutedEventArgs e) { Application.Current.Shutdown(); }
        
        private void Deact(object sender, RoutedEventArgs e) { Application.Current.MainWindow.WindowState = WindowState.Minimized; }
        
        private void Drag(object sender, RoutedEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed) { Application.Current.MainWindow.DragMove(); }
        }

        private void NewTheme(object sender, RoutedEventArgs e)
        {
            Uri uri;
            if (!Theme.isDarkTheme) { uri = new Uri(@"..\Themes\BlackTheme.xaml", UriKind.Relative); }
            else { uri = new Uri(@"..\Themes\LightTheme.xaml", UriKind.Relative); }
            Theme.isDarkTheme = !(Theme.isDarkTheme);
            ResourceDictionary resDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resDict);
            RadiusMinBox.Focus();
        }

        private void ResultButton(object sender, RoutedEventArgs e)
        {
            try
            {
                double radiusRLower = 0, radiusRUpper = 0, height = 0;
                int accuracy = 3;
                try
                {
                    radiusRLower = Convert.ToDouble(RadiusMinBox.Text);
                    if (radiusRLower < 0) { throw new Exception(); }
                } catch { throw new Exception("Некорректно введённый радиус меньшего основания!"); }
                try
                {
                    radiusRUpper = Convert.ToDouble(RadiusMaxBox.Text);
                    if (radiusRUpper < 0) { throw new Exception(); }
                } catch { throw new Exception("Некорректно введённый радиус большего основания!"); }
                try
                {
                    height = Convert.ToDouble(HeightBox.Text);
                    if (height < 0) { throw new Exception(); }
                } catch { throw new Exception("Некорректно введённая высота!"); }
                try
                {
                    accuracy = Convert.ToInt32(AccuracyBox.Text);
                    if (accuracy < 0) { throw new Exception(); }
                } catch { MessageBox.Show("Некорректно введена точность! По умолчанию - 3 символа", "Ошибка преобразования", MessageBoxButton.OK, MessageBoxImage.Warning); }

                double forming = Math.Sqrt(Math.Pow((radiusRUpper - radiusRLower), 2) + Math.Pow(height, 2));
                double flu = forming * (radiusRLower + radiusRUpper);

                ResultSquareMinBaseBox.Text =  Math.Round(Math.PI * Math.Pow(radiusRLower, 2), accuracy).ToString();
                ResultSquareMaxBaseBox.Text = Math.Round(Math.PI * Math.Pow(radiusRUpper, 2), accuracy).ToString();
                ResultSquareSideBox.Text = Math.Round(Math.PI * flu, accuracy).ToString();
                ResultSquareBox.Text = Math.Round(Math.PI * (Math.Pow(radiusRLower, 2) + Math.Pow(radiusRUpper, 2) + flu), accuracy).ToString();
                ResultVolumeBox.Text = Math.Round((Math.PI / 3.0) * height * (Math.Pow(radiusRLower, 2) + Math.Pow(radiusRUpper, 2) + radiusRLower * radiusRUpper), accuracy).ToString();
            } catch (Exception Ex) { MessageBox.Show(Ex.Message, "Ошибка преобразования", MessageBoxButton.OK, MessageBoxImage.Error); }
            RadiusMinBox.Focus();
        }
    }
}