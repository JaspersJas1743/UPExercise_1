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
    public partial class Cylinder : Page
    {
        public Cylinder() { InitializeComponent(); }

        private void BackButtonCylinder(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Menu()); }
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

                ResultSquareBaseBox.Text = Math.Round(Math.PI * Math.Pow(radius, 2), accuracy).ToString();
                ResultSquareSideBox.Text = Math.Round(2 * Math.PI * radius * height, accuracy).ToString();
                ResultSquareBox.Text = Math.Round(2 * Math.PI * radius * (radius + height), accuracy).ToString();
                ResultVolumeBox.Text = Math.Round(Math.PI * Math.Pow(radius, 2) * height, accuracy).ToString();
            } catch {}
            RadiusBox.Focus();
        }
    }
}