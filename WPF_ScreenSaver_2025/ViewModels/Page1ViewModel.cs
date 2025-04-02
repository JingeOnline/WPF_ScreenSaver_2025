using Microsoft.Web.WebView2.Wpf;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_ScreenSaver_2025.Helpers;
using WPF_ScreenSaver_2025.Models;

namespace WPF_ScreenSaver_2025.ViewModels
{
    class Page1ViewModel : BindableBase
    {
        public ObservableCollection<WebViewModel> WebViewCollection { get; set; } = new ObservableCollection<WebViewModel>();
        private WebViewModel _SelectedWebView;
        public WebViewModel SelectedWebView
        {
            get { return _SelectedWebView; }
            set { SetProperty(ref _SelectedWebView, value); }
        }

        private VerticalAlignment _SettingBarAlignment = VerticalAlignment.Bottom;
        public VerticalAlignment SettingBarAlignment
        {
            get { return _SettingBarAlignment; }
            set { SetProperty(ref _SettingBarAlignment, value); }
        }

        public DelegateCommand SaveCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }
        public DelegateCommand PreviewCommand { get; set; }

        public Action<WebView2> loadWebView2Element;

        public Page1ViewModel()
        {
            SaveCommand = new DelegateCommand(Save);
            PreviewCommand = new DelegateCommand(ChangeWebViewBackgroundColor);
            Helper.SettingBarAlignmentChanged += ChangeSettingBarAlignment;
            Load();
        }


        public void ChangeSettingBarAlignment()
        {
            if (SettingBarAlignment == VerticalAlignment.Top)
            {
                SettingBarAlignment = VerticalAlignment.Bottom;
            }
            else
            {
                SettingBarAlignment = VerticalAlignment.Top;
            }
        }

        public async Task Load()
        {
            //这里等待1毫秒是为了让View的构造函数执行完，否则Action还来不急挂载
            await Task.Delay(1);
            IEnumerable<WebViewModel> models = Helper.JsonWebViews.Where(x => x.PageNumber == 1);
            //WebViewCollection = new ObservableCollection<WebViewModel>(models);
            foreach (var item in models)
            {
                WebViewCollection.Add(item);
            }
            foreach (WebViewModel model in WebViewCollection)
            {
                loadWebView2Element?.Invoke(model.WebView);
                await model.WebView.EnsureCoreWebView2Async();
                model.WebView.DefaultBackgroundColor = Helper.WvBgColor;
                model.WebView.CoreWebView2.NavigateToString(model.Url);
                //隐藏滚动条
                model.WebView.NavigationCompleted += (sender, e) =>
                {
                    if (e.IsSuccess)
                    {
                        ((Microsoft.Web.WebView2.Wpf.WebView2)sender).ExecuteScriptAsync("document.querySelector('body').style.overflow='hidden'");
                    }
                };
            }
        }

        public void Save()
        {
            Helper.SaveAllWebViewsToJson();
            //Debug.WriteLine(SelectedWebView.Name);
            //Helper.SaveToJsonFile(WebViewCollection);
        }

        public async void ChangeWebViewBackgroundColor()
        {
            foreach (WebViewModel model in WebViewCollection)
            {
                model.WebView.DefaultBackgroundColor = Helper.Color_Transparent;
            }
            await Task.Delay(3000);
            foreach (WebViewModel model in WebViewCollection)
            {
                model.WebView.DefaultBackgroundColor = Helper.Color_Gray;
            }
        }
    }
}
