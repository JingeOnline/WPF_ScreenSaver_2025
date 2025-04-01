using Microsoft.Web.WebView2.Wpf;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_ScreenSaver_2025.Models
{
    public class WebViewModel : BindableBase
    {
        [JsonIgnore]
        public WebView2 WebView { get; set; }
        public int PageNumber { get; set; }
        public string Url { get; set; }

        public string Name
        {
            get { return WebView.Name; }
            set { WebView.Name = value; }
        }
        public double ZoomFactor
        {
            get { return WebView.ZoomFactor; }
            set { WebView.ZoomFactor = value; RaisePropertyChanged(nameof(WebView));RaisePropertyChanged(nameof(ZoomFactor)); }
        }

        public double MarginTop
        {
            get { return Margin.Top; }
            set { Margin = new Thickness(MarginLeft, value, MarginRight, MarginBottom);}
        }
        public double MarginBottom
        {
            get { return Margin.Bottom; }
            set { Margin = new Thickness(MarginLeft, MarginTop, MarginRight, value); }
        }
        public double MarginLeft
        {
            get { return Margin.Left; }
            set { Margin = new Thickness(value, MarginTop, MarginRight, MarginBottom); }
        }
        public double MarginRight
        {
            get { return Margin.Right; }
            set { Margin = new Thickness(MarginLeft, MarginTop, value, MarginBottom); }
        }
        [JsonIgnore]
        public Thickness Margin
        {
            get { return WebView.Margin; }
            set { WebView.Margin = value; RaisePropertyChanged(nameof(WebView)); }
        }

        public double Height
        {
            get { return WebView.Height; }
            set { WebView.Height = value; RaisePropertyChanged(nameof(WebView)); }
        }

        public double Width
        {
            get { return WebView.Width; }
            set { WebView.Width = value; RaisePropertyChanged(nameof(WebView)); }
        }

        public WebViewModel()
        {
            WebView = new WebView2();
        }

        public WebViewModel(WebView2 webView2, int pageNum, string url)
        {
            WebView = webView2;
            PageNumber = pageNum;
            Url = url;
        }
    }
}
