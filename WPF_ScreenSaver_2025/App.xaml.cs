using Prism.Ioc;
using WPF_ScreenSaver_2025.Views;
using System.Windows;
using Prism.Regions;
using System.Windows.Controls;
using System;

namespace WPF_ScreenSaver_2025
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        //程序启动参数，当屏幕保护程序被设置的时候，启动设置页面；运行程序保护程序的时候，启动运行页面。
        private StartupEventArgs _startupEventArgs;

        protected override void OnStartup(StartupEventArgs e)
        {
            _startupEventArgs = e;
            base.OnStartup(e);
        }

        protected override Window CreateShell()
        {
            string[] args = _startupEventArgs.Args;

            if (args.Length > 0)
            {
                string firstArgument = args[0].ToLower().Trim();
                string secondArgument = null;

                // Handle cases where arguments are separated by colon.
                // Examples: /c:1234567 or /P:1234567
                if (firstArgument.Length > 2)
                {
                    secondArgument = firstArgument.Substring(3).Trim();
                    firstArgument = firstArgument.Substring(0, 2);
                }
                else if (args.Length > 1)
                    secondArgument = args[1];

                if (firstArgument == "/c")           // Configuration mode
                {
                    return Container.Resolve<SettingWindow>();
                }
                else if (firstArgument == "/p")      // Preview mode
                {
                    throw new NotImplementedException();
                    //return Container.Resolve<SettingWindow>();
                }
                else if (firstArgument == "/s")      // Full-screen mode
                {
                    return Container.Resolve<MainWindow>();
                }
                else    // Undefined argument
                {
                    MessageBox.Show("Sorry, but the command line argument \"" + firstArgument +
                        "\" is not valid.", "ScreenSaver",
                        MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    throw new NotImplementedException();
                }
            }
            else    // No arguments - treat like /c
            {
                return Container.Resolve<MainWindow>();
                //throw new NotImplementedException();
            }
            //return Container.Resolve<MainWindow>();
            //if (_startupEventArgs.Args.ToString() == "/p")
            //{
            //    return Container.Resolve<SettingWindow>();
            //}
            //else
            //{
            //    return Container.Resolve<MainWindow>();
            //}
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }



        protected override void OnInitialized()
        {
            base.OnInitialized();
            //获得RegionManager实例
            IRegionManager regionManager = Container.Resolve<IRegionManager>();
            //指定Region的名称，和程序启动时要填充的View的
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Page0));
        }
    }
}
