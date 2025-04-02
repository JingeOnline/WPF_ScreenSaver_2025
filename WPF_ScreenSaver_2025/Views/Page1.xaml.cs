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
using WPF_ScreenSaver_2025.ViewModels;

namespace WPF_ScreenSaver_2025.Views
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : UserControl
    {

        //public readonly string Clock_Round = "<iframe src=\"https://free.timeanddate.com/clock/i8xa9g0h/n152/szw700/szh700/hoc444/hbw4/hfceee/cf100/hgr0/fdi76/mqc444/mql10/mqw4/mqd98/mhc444/mhl10/mhw4/mhd98/mmc444/mml10/mmw1/mmd98/hhl50/hhw6\" frameborder=\"0\" width=\"700\" height=\"700\"></iframe>\r\n";
        //public readonly string Rates1 = "<div class=\"tradingview-widget-container\">\r\n    <div class=\"tradingview-widget-container__widget\"></div>\r\n    <script type=\"text/javascript\" src=\"https://s3.tradingview.com/external-embedding/embed-widget-symbol-overview.js\" async>\r\n    {\r\n    \"symbols\": [\r\n      [\r\n        \"FX_IDC:AUDCNY|12M\"\r\n      ]\r\n    ],\r\n    \"chartOnly\": false,\r\n    \"width\": \"100%\",\r\n    \"height\": \"100%\",\r\n    \"locale\": \"zh_CN\",\r\n    \"colorTheme\": \"dark\",\r\n    \"autosize\": true,\r\n    \"showVolume\": false,\r\n    \"showMA\": false,\r\n    \"hideDateRanges\": false,\r\n    \"hideMarketStatus\": false,\r\n    \"hideSymbolLogo\": false,\r\n    \"scalePosition\": \"right\",\r\n    \"scaleMode\": \"Normal\",\r\n    \"fontFamily\": \"-apple-system, BlinkMacSystemFont, Trebuchet MS, Roboto, Ubuntu, sans-serif\",\r\n    \"fontSize\": \"15\",\r\n    \"noTimeScale\": false,\r\n    \"valuesTracking\": \"1\",\r\n    \"changeMode\": \"price-and-percent\",\r\n    \"chartType\": \"area\",\r\n    \"maLineColor\": \"#2962FF\",\r\n    \"maLineWidth\": 1,\r\n    \"maLength\": 9,\r\n    \"headerFontSize\": \"medium\",\r\n    \"backgroundColor\": \"rgba(15, 15, 15, 0)\",\r\n    \"lineWidth\": 2,\r\n    \"lineType\": 0,\r\n    \"dateRanges\": [\r\n      \"1d|1\",\r\n      \"1m|30\",\r\n      \"3m|60\",\r\n      \"12m|1D\",\r\n      \"60m|1W\",\r\n      \"all|1M\"\r\n    ],\r\n    \"lineColor\": \"rgba(76, 175, 80, 1)\",\r\n    \"topColor\": \"rgba(76, 175, 80, 0.6)\",\r\n    \"bottomColor\": \"rgba(99, 99, 99, 0)\"\r\n  }\r\n    </script>\r\n  </div>";
        //public readonly string Rates2 = "<div class=\"tradingview-widget-container\">\r\n    <div class=\"tradingview-widget-container__widget\"></div>\r\n    <script type=\"text/javascript\" src=\"https://s3.tradingview.com/external-embedding/embed-widget-symbol-overview.js\" async>\r\n    {\r\n    \"symbols\": [\r\n      [\r\n        \"FX_IDC:USDCNY|12M\"\r\n      ]\r\n    ],\r\n    \"chartOnly\": false,\r\n    \"width\": \"100%\",\r\n    \"height\": \"100%\",\r\n    \"locale\": \"zh_CN\",\r\n    \"colorTheme\": \"dark\",\r\n    \"autosize\": true,\r\n    \"showVolume\": false,\r\n    \"showMA\": false,\r\n    \"hideDateRanges\": false,\r\n    \"hideMarketStatus\": false,\r\n    \"hideSymbolLogo\": false,\r\n    \"scalePosition\": \"right\",\r\n    \"scaleMode\": \"Normal\",\r\n    \"fontFamily\": \"-apple-system, BlinkMacSystemFont, Trebuchet MS, Roboto, Ubuntu, sans-serif\",\r\n    \"fontSize\": \"15\",\r\n    \"noTimeScale\": false,\r\n    \"valuesTracking\": \"1\",\r\n    \"changeMode\": \"price-and-percent\",\r\n    \"chartType\": \"area\",\r\n    \"maLineColor\": \"#2962FF\",\r\n    \"maLineWidth\": 1,\r\n    \"maLength\": 9,\r\n    \"headerFontSize\": \"medium\",\r\n    \"backgroundColor\": \"rgba(15, 15, 15, 0)\",\r\n    \"lineWidth\": 2,\r\n    \"lineType\": 0,\r\n    \"dateRanges\": [\r\n      \"1d|1\",\r\n      \"1m|30\",\r\n      \"3m|60\",\r\n      \"12m|1D\",\r\n      \"60m|1W\",\r\n      \"all|1M\"\r\n    ],\r\n    \"lineColor\": \"rgba(255, 152, 0, 1)\",\r\n    \"topColor\": \"rgba(255, 152, 0, 0.6)\",\r\n    \"bottomColor\": \"rgba(99, 99, 99, 0)\"\r\n  }\r\n    </script>\r\n  </div>";
        //public readonly string Weather_Week = "<a class=\"weatherwidget-io\" href=\"https://forecast7.com/zh/n35d18149d11/ngunnawal/\" data-label_1=\"NGUNNAWAL\" data-label_2=\"ACT\" data-font=\"微软雅黑 (Microsoft Yahei)\" data-icons=\"Climacons Animated\" data-theme=\"dark\" data-accent=\"rgba(255, 255, 255, 0)\" >NGUNNAWAL ACT</a>\r\n<script>\r\n!function(d,s,id){var js,fjs=d.getElementsByTagName(s)[0];if(!d.getElementById(id)){js=d.createElement(s);js.id=id;js.src='https://weatherwidget.io/js/widget.min.js';fjs.parentNode.insertBefore(js,fjs);}}(document,'script','weatherwidget-io-js');\r\n</script>";
        Page1ViewModel _VM;
        public Page1()
        {
            InitializeComponent();
            _VM = this.DataContext as Page1ViewModel;
            _VM.loadWebView2Element = LoadWebView2Element;
            //Run();
        }
        public void LoadWebView2Element(WebView2 wv2)
        {
            Grid_Root.Children.Add(wv2);
        }
        //public async Task Run()
        //{
        //    WebView2 rate1 = new WebView2();
        //    Grid_Root.Children.Add(rate1);
        //    rate1.ZoomFactor = 1.1;
        //    rate1.Height = 500;
        //    rate1.Width = 1900;
        //    rate1.HorizontalAlignment = HorizontalAlignment.Center;
        //    rate1.VerticalAlignment = VerticalAlignment.Center;
        //    rate1.Margin = new Thickness(0, 400, 0, 0);

        //    await rate1.EnsureCoreWebView2Async();
        //    rate1.DefaultBackgroundColor = System.Drawing.Color.Transparent;
        //    rate1.NavigateToString(Rates1);
        //    rate1.NavigationCompleted += (sender, e) =>
        //    {
        //        if (e.IsSuccess)
        //        {
        //            ((Microsoft.Web.WebView2.Wpf.WebView2)sender).ExecuteScriptAsync("document.querySelector('body').style.overflow='hidden'");
        //        }
        //    };



        //    WebView2 rate2 = new WebView2();
        //    Grid_Root.Children.Add(rate2);
        //    rate2.ZoomFactor = 1.1;
        //    rate2.Height = 500;
        //    rate2.Width = 1900;
        //    rate2.HorizontalAlignment = HorizontalAlignment.Center;
        //    rate2.VerticalAlignment = VerticalAlignment.Center;
        //    rate2.Margin = new Thickness(0, 0, 0, 400);

        //    await rate2.EnsureCoreWebView2Async();
        //    rate2.DefaultBackgroundColor = System.Drawing.Color.Transparent;
        //    rate2.NavigateToString(Rates2);
        //    rate2.NavigationCompleted += (sender, e) =>
        //    {
        //        if (e.IsSuccess)
        //        {
        //            ((Microsoft.Web.WebView2.Wpf.WebView2)sender).ExecuteScriptAsync("document.querySelector('body').style.overflow='hidden'");
        //        }
        //    };
        //}
    }
}
