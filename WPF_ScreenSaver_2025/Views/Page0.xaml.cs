using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Web.WebView2.Wpf;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_ScreenSaver_2025.Helpers;
using WPF_ScreenSaver_2025.Models;
using WPF_ScreenSaver_2025.ViewModels;
using System.Windows.Media.Animation;

namespace WPF_ScreenSaver_2025.Views
{
    /// <summary>
    /// Interaction logic for Page0.xaml
    /// </summary>
    public partial class Page0 : UserControl
    {
        Page0ViewModel _VM;
        public readonly string Clock_Round = "<iframe src=\"https://free.timeanddate.com/clock/i8xa9g0h/n152/szw700/szh700/hoc444/hbw4/hfceee/cf100/hgr0/fdi76/mqc444/mql10/mqw4/mqd98/mhc444/mhl10/mhw4/mhd98/mmc444/mml10/mmw1/mmd98/hhl50/hhw6\" frameborder=\"0\" width=\"700\" height=\"700\"></iframe>\r\n";
        public readonly string Clock_Digital = "<iframe src=\"https://free.timeanddate.com/clock/i8xbctym/n152/tlau/fs48/fcfff/tct/pct/tt0/tm3/ts1/tb4\" frameborder=\"0\" width=\"518\" height=\"112\" allowtransparency=\"true\"></iframe>\r\n";
        public readonly string Weather_Week = "<a class=\"weatherwidget-io\" href=\"https://forecast7.com/zh/n35d18149d11/ngunnawal/\" data-label_1=\"NGUNNAWAL\" data-label_2=\"ACT\" data-font=\"微软雅黑 (Microsoft Yahei)\" data-icons=\"Climacons Animated\" data-theme=\"dark\" data-accent=\"rgba(255, 255, 255, 0)\" >NGUNNAWAL ACT</a>\r\n<script>\r\n!function(d,s,id){var js,fjs=d.getElementsByTagName(s)[0];if(!d.getElementById(id)){js=d.createElement(s);js.id=id;js.src='https://weatherwidget.io/js/widget.min.js';fjs.parentNode.insertBefore(js,fjs);}}(document,'script','weatherwidget-io-js');\r\n</script>";
        public readonly string Weather_Hours = "<iframe src=\"https://www.meteoblue.com/en/weather/widget/three?geoloc=detect&nocurrent=0&noforecast=0&days=5&tempunit=CELSIUS&windunit=KILOMETER_PER_HOUR&layout=dark\"  frameborder=\"0\" scrolling=\"NO\" allowtransparency=\"true\" sandbox=\"allow-same-origin allow-scripts allow-popups allow-popups-to-escape-sandbox\" style=\"width: 575px; height: 607px\"></iframe><div></div>";
        //public readonly string Weather_Week = "<a class=\"weatherwidget-io\" href=\"https://forecast7.com/zh/n38d15144d36/geelong/\" data-label_1=\"GEELONG\" data-label_2=\"WEATHER\" data-font=\"微软雅黑 (Microsoft Yahei)\" data-theme=\"dark\" data-accent=\"rgba(255, 255, 255, 0)\" >GEELONG WEATHER</a>\r\n<script>\r\n!function(d,s,id){var js,fjs=d.getElementsByTagName(s)[0];if(!d.getElementById(id)){js=d.createElement(s);js.id=id;js.src='https://weatherwidget.io/js/widget.min.js';fjs.parentNode.insertBefore(js,fjs);}}(document,'script','weatherwidget-io-js');\r\n</script>";
        //public readonly string Weather_Hours = "<iframe src=\"https://www.meteoblue.com/en/weather/widget/three/geelong_australia_2165798?geoloc=fixed&nocurrent=0&noforecast=0&days=5&tempunit=CELSIUS&windunit=KILOMETER_PER_HOUR&layout=dark\"  frameborder=\"0\" scrolling=\"NO\" allowtransparency=\"true\" sandbox=\"allow-same-origin allow-scripts allow-popups allow-popups-to-escape-sandbox\" style=\"width: 575px; height: 609px\"></iframe>";


        public Page0()
        {
            InitializeComponent();
            _VM = this.DataContext as Page0ViewModel;
            _VM.loadWebView2Element = LoadWebView2Element;
            //Run();
        }

        public void LoadWebView2Element(WebView2 wv2)
        {
            Grid_Root.Children.Add(wv2);
        }

        public async Task Run()
        {
            //System.Drawing.Color wvBgColor;
            //if (App.IsSettingMode)
            //{
            //    wvBgColor =System.Drawing.Color.Gray;
            //}
            //else
            //{
            //    wvBgColor=System.Drawing.Color.Transparent;
            //}



            //await wv_Weather.EnsureCoreWebView2Async();
            //wv_Weather.DefaultBackgroundColor = wvBgColor;
            //wv_Weather.CoreWebView2.NavigateToString(Weather_Hours);
            ////隐藏滚动条
            //wv_Weather.NavigationCompleted += (sender, e) =>
            //{
            //    if (e.IsSuccess)
            //    {
            //        ((Microsoft.Web.WebView2.Wpf.WebView2)sender).ExecuteScriptAsync("document.querySelector('body').style.overflow='hidden'");
            //    }
            //};
            //List<WebViewModel> list = new List<WebViewModel>();
            //list.Add(new WebViewModel(wv_Weather, 0, Weather_Hours));
            //Helper.SaveToJsonFile(list);

            //WebView2 wvClock = new WebView2();
            //Grid_Root.Children.Add(wvClock);
            //wvClock.ZoomFactor = 1;
            //wvClock.Height = 720;
            //wvClock.Width = 720;
            //wvClock.HorizontalAlignment = HorizontalAlignment.Left;
            //wvClock.VerticalAlignment = VerticalAlignment.Top;
            //wvClock.Margin = new Thickness(140, 100, 0, 0);

            //await wvClock.EnsureCoreWebView2Async();
            //wvClock.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            //wvClock.NavigateToString(Clock_Round);


            //WebView2 wvWeatherWeek = new WebView2();
            //Grid_Root.Children.Add(wvWeatherWeek);
            //wvWeatherWeek.ZoomFactor = 1.5;
            //wvWeatherWeek.Height = 200;
            //wvWeatherWeek.Width = 1880;
            //wvWeatherWeek.HorizontalAlignment = HorizontalAlignment.Center;
            //wvWeatherWeek.VerticalAlignment = VerticalAlignment.Bottom;
            //wvWeatherWeek.Margin = new Thickness(0, 0, 0, 0);

            //await wvWeatherWeek.EnsureCoreWebView2Async();
            //wvWeatherWeek.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            //wvWeatherWeek.NavigateToString(Weather_Week);

            //WebView2 wvWeatherHours = new WebView2();
            //Grid_Root.Children.Add(wvWeatherHours);
            //wvWeatherHours.ZoomFactor = 1.5;
            //wvWeatherHours.Height = 1000;
            //wvWeatherHours.Width = 1000;
            //wvWeatherHours.HorizontalAlignment = HorizontalAlignment.Center;
            //wvWeatherHours.VerticalAlignment = VerticalAlignment.Center;
            //wvWeatherHours.Margin = new Thickness(0, 0, 0, 0);

            //await wvWeatherHours.EnsureCoreWebView2Async();
            //wvWeatherHours.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            //wvWeatherHours.CoreWebView2.NavigateToString(Weather_Hours);
            ////隐藏滚动条
            //wvWeatherHours.NavigationCompleted += (sender, e) =>
            //{
            //    if (e.IsSuccess)
            //    {
            //        ((Microsoft.Web.WebView2.Wpf.WebView2)sender).ExecuteScriptAsync("document.querySelector('body').style.overflow='hidden'");
            //    }
            //};

        }
    }
}
