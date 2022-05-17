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
    public partial class Cone : Page
    {
        public Cone()
        {
            InitializeComponent();
            RadiusBox.Focus();
        }

        private void Exit(object sender, RoutedEventArgs e) { Application.Current.Shutdown(); }
        
        private void Deact(object sender, RoutedEventArgs e) { Application.Current.MainWindow.WindowState = WindowState.Minimized; }

        private void BackButtonCone(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Menu()); }

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
            RadiusBox.Focus();
        }

        private void ResultButton(object sender, RoutedEventArgs e)
        {
            try
            {
                double radius = 0, height = 0;
                int accuracy = 3;
                try
                {
                    radius = Convert.ToDouble(RadiusBox.Text);
                    if (radius < 0) { throw new Exception(); }
                } catch { throw new Exception("Некорректно введённый радиус!"); }
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

                double forming = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));
                double squareBase = Math.Round(Math.PI * Math.Pow(radius, 2), accuracy);
                double squareSide = Math.Round(Math.PI * radius * forming, accuracy);

                ResultSquareBaseBox.Text = squareBase.ToString();
                ResultSquareSideBox.Text = squareSide.ToString();
                ResultSquareBox.Text = Math.Round(squareBase + squareSide, accuracy).ToString();
                ResultVolumeBox.Text = Math.Round((1.0 / 3) * squareBase * height, accuracy).ToString();
            } catch (Exception Ex) { MessageBox.Show(Ex.Message, "Ошибка преобразования", MessageBoxButton.OK, MessageBoxImage.Error); }
            RadiusBox.Focus();
        }
    }
}