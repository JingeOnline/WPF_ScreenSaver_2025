using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Threading.Tasks;
using System.Windows;
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

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _RegionManager = regionManager;
            EscCommand = new DelegateCommand(EscKeyDown);
            NextCommand = new DelegateCommand(RightKeyDown);
            BackCommand = new DelegateCommand(LeftKeyDown);
        }

        private void EscKeyDown()
        {
            Application.Current.Shutdown();
        }

        private async void RightKeyDown()
        {
            IsPageChanged=true;
            await Task.Delay(2000);
            _RegionManager.RequestNavigate("ContentRegion", nameof(Page1));
            IsPageChanged = false;
        }

        private async void LeftKeyDown()
        {
            IsPageChanged=true;
            await Task.Delay(2000);
            _RegionManager.RequestNavigate("ContentRegion", nameof(Page0));
            IsPageChanged = false;
        }
    }
}
