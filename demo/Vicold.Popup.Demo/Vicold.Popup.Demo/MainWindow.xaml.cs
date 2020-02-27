using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vicold.Popup.Demo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            switch (int.Parse(btn.Tag.ToString()))
            {
                case 0:
                    Alert.Show("Normal");
                    break;
                case 1:
                    Alert.Show("Title", "Normal With Title");
                    break;
                case 2:
                    Alert.Show("Use Error Theme", AlertTheme.Error);
                    break;
                case 3:
                    Alert.Show("Use Success Theme", AlertTheme.Success);
                    break;
                case 4:
                    Alert.Show("", "Take One Button", AlertTheme.Default, new UserButton("Click Me", () =>
                     {
                         MessageBox.Show("You clicked one button");
                     }));
                    break;
                case 5:
                    var btn2 = new UserButton("Click Me", () => { });
                    btn2.LoadAlertTheme(AlertTheme.Success);
                    Alert.Show("Title", "Take Two Themes Button", AlertTheme.Default, new UserButton("Click Me", () => { })
                    {
                        BackgroundColor = Color.Red,
                        BorderColor = Color.Crimson,
                        FontColor = Color.LightSkyBlue,
                        FontSize = 15,
                    }, btn2, null);
                    break;
                case 6:
                    var closeAction = new Action(() =>
                    {
                        MessageBox.Show("Alert Has Closed");

                    });
                    Alert.Show("Title", "With AlertConfig", AlertTheme.Default, new List<UserButton> { new UserButton("Click Me", () => { }) }, new AlertConfig()
                    {
                        AlertShowDuration = 5000,
                        AnimationDuration = 500,
                        OnlyOneWindowAllowed = true,
                        OnAlertCloseCallback = closeAction
                    });
                    break;
            }
        }
    }
}
