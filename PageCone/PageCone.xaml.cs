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

        private void BackButtonCone(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Menu()); }

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

                double forming = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));
                double squareBase = Math.Round(Math.PI * Math.Pow(radius, 2), accuracy);
                double squareSide = Math.Round(Math.PI * radius * forming, accuracy);

                ResultSquareBaseBox.Text = squareBase.ToString();
                ResultSquareSideBox.Text = squareSide.ToString();
                ResultSquareBox.Text = Math.Round(squareBase + squareSide, accuracy).ToString();
                ResultVolumeBox.Text = Math.Round((1.0 / 3) * squareBase * height, accuracy).ToString();
            } catch {}
            RadiusBox.Focus();
        }
    }
}