using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Threading.Tasks;
using System.Windows;
using WPF_ScreenSaver_2025.Helpers;
using WPF_ScreenSaver_2025.Views;

namespace WPF_ScreenSaver_2025.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private IRegionManager _RegionManager;

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _IsPageChanged;
        public bool IsPageChanged
        {
            get { return _IsPageChanged; }
            set { SetProperty(ref _IsPageChanged, value); }
        }



        public DelegateCommand EscCommand { get; set; }
        public DelegateCommand NextCommand { get; set; }
        public DelegateCommand BackCommand { get; set; }
        public DelegateCommand ControlCommand { get; set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _RegionManager = regionManager;
            EscCommand = new DelegateCommand(ShutDownApp);
            NextCommand = new DelegateCommand(NextPage);
            BackCommand = new DelegateCommand(BackPage);
            ControlCommand = new DelegateCommand(SwitchSettingBarAlignment);
            Helper.JsonWebViews = Helper.ReadJosnFile();
        }

        private void ShutDownApp()
        {
            Application.Current.Shutdown();
        }

        private void SwitchSettingBarAlignment()
        {
             Helper.SettingBarAlignmentChanged?.Invoke();
        }

        private async void NextPage()
        {
            IsPageChanged = true;
            await Task.Delay(2000);
            _RegionManager.RequestNavigate("ContentRegion", nameof(Page1));
            IsPageChanged = false;
        }

        private async void BackPage()
        {
            IsPageChanged = true;
            await Task.Delay(2000);
            _RegionManager.RequestNavigate("ContentRegion", nameof(Page0));
            IsPageChanged = false;
        }
    }
}
