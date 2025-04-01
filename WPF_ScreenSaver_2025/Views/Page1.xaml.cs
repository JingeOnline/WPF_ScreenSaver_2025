using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_ScreenSaver_2025.Views
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : UserControl
    {

        public readonly string Clock_Round = "<iframe src=\"https://free.timeanddate.com/clock/i8xa9g0h/n152/szw700/szh700/hoc444/hbw4/hfceee/cf100/hgr0/fdi76/mqc444/mql10/mqw4/mqd98/mhc444/mhl10/mhw4/mhd98/mmc444/mml10/mmw1/mmd98/hhl50/hhw6\" frameborder=\"0\" width=\"700\" height=\"700\"></iframe>\r\n";
        public Page1()
        {
            InitializeComponent();
            Run();
        }

        public async Task Run()
        {
            WebView2 wvClock = new WebView2();
            Grid_Root.Children.Add(wvClock);
            wvClock.ZoomFactor = 1.4;
            wvClock.Height = 1000;
            wvClock.Width = 1000;
            wvClock.HorizontalAlignment = HorizontalAlignment.Center;
            wvClock.VerticalAlignment = VerticalAlignment.Center;
            //wvClock.Margin = new Thickness(140, 100, 0, 0);

            await wvClock.EnsureCoreWebView2Async();
            wvClock.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            wvClock.NavigateToString(Clock_Round);
            wvClock.NavigationCompleted += (sender, e) =>
            {
                if (e.IsSuccess)
                {
                    ((Microsoft.Web.WebView2.Wpf.WebView2)sender).ExecuteScriptAsync("document.querySelector('body').style.overflow='hidden'");
                }
            };
        }
    }
}
