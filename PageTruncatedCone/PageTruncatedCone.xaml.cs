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
        public TruncatedCone() { InitializeComponent(); }

        private void BackButtonTruncatedCone(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Menu()); }
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
                } catch { 
                    MessageBox.Show("Некорректно введённый радиус!", "Ошибка преобразования", MessageBoxButton.OK, MessageBoxImage.Error);
                    throw new Exception(); 
                }
                try
                {
                    radiusRUpper = Convert.ToDouble(RadiusMaxBox.Text);
                    if (radiusRUpper < 0) { throw new Exception(); }
                } catch { 
                    MessageBox.Show("Некорректно введённый радиус!", "Ошибка преобразования", MessageBoxButton.OK, MessageBoxImage.Error);
                    throw new Exception(); 
                }
                try
                {
                    height = Convert.ToDouble(HeightBox.Text);
                    if (height < 0) { throw new Exception(); }
                } catch { 
                    MessageBox.Show("Некорректно введённая высота!", "Ошибка преобразования", MessageBoxButton.OK, MessageBoxImage.Error);
                    throw new Exception();
                }
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
            } catch {}
            RadiusMinBox.Focus();
        }
    }
}