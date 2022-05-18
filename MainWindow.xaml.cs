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
    public partial class MainWindow : Window
    {
        public static MainWindow? Window;
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new Menu();
        }

        public static void MouseDrug()
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed) { Application.Current.MainWindow.DragMove(); }
        }

        public static void ResetTheme()
        {
            Uri uri;
            if (!Theme.isDarkTheme) { uri = new Uri(@"..\Themes\BlackTheme.xaml", UriKind.Relative); }
            else { uri = new Uri(@"..\Themes\LightTheme.xaml", UriKind.Relative); }
            Theme.isDarkTheme = !(Theme.isDarkTheme);
            ResourceDictionary? resDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resDict);
        }
    }
}
