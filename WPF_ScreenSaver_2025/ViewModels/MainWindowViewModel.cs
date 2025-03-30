using Prism.Commands;
using Prism.Mvvm;
using System.Windows;

namespace WPF_ScreenSaver_2025.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand EscCommand { get; set; }
        public DelegateCommand NextCommand { get; set; }
        public DelegateCommand BackCommand { get; set; }

        public MainWindowViewModel()
        {
            EscCommand = new DelegateCommand(EscKeyDown);
        }

        private void EscKeyDown()
        {
            Application.Current.Shutdown();
        }
    }
}
