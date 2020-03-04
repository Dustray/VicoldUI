using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Vicold.UI.Shell
{
    /// <summary>
    /// 
    /// </summary>
    public class TitleShell : Window
    {
        /// <summary>
        /// 
        /// </summary>
        public TitleShell()
        {
            

            
            
        }
        /// <summary>
        /// 
        /// </summary>
        public void abc()
        {
            var s = (ResourceDictionary)App.LoadComponent(new Uri(@"/Vicold.UI.Shell;component/Styles/ToolBarButton.xaml", UriKind.Relative));
            this.Resources.MergedDictionaries.Add(s);
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.None;
            Background = new SolidColorBrush(Color.FromArgb(255, 230, 230, 230));
            var grid = new Grid();
            grid.Background = new SolidColorBrush(Color.FromArgb(60, 255, 255, 255));
            grid.Height = 50;
            grid.VerticalAlignment = VerticalAlignment.Top;
            grid.MouseLeftButtonDown += (sender, e) => { DragMove(); };
            var tbTitle = new TextBlock();
            tbTitle.FontSize = 25;
            tbTitle.Margin = new Thickness(10);
            tbTitle.VerticalAlignment = VerticalAlignment.Center;
            tbTitle.HorizontalAlignment = HorizontalAlignment.Left;
            tbTitle.Text = "标题";
            grid.Children.Add(tbTitle);
            var btnClose = new Button();
            btnClose.Style =  (Style)this.FindResource("ToolBarBtnStyle");
            btnClose.HorizontalAlignment = HorizontalAlignment.Right;
            btnClose.Content = ((char)0xEF2C).ToString();
            btnClose.ToolTip = "关闭";
            btnClose.Margin = new Thickness(0, 0, 10, 0);
            btnClose.Click += (sender, e) => { Close(); };
            grid.Children.Add(btnClose);
            AddChild(grid);
        }
    }
}
