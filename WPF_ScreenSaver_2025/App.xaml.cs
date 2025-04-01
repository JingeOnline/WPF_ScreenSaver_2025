using Prism.Ioc;
using WPF_ScreenSaver_2025.Views;
using System.Windows;
using Prism.Regions;
using System.Windows.Controls;
using System;
using NLog;
using System.Linq;

namespace WPF_ScreenSaver_2025
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        //程序启动参数，当屏幕保护程序被设置的时候，启动设置页面；运行程序保护程序的时候，启动运行页面。
        private StartupEventArgs _startupEventArgs;
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        //判断屏幕保护程序的启动模式，是运行模式还是配置模式。
        public static bool IsSettingMode = false;

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
                logger.Info("Startup - arguments: " + string.Join("", args));
                string firstArgument = args[0].ToLower().Trim();
                string secondArgument = null;

                // Handle cases where arguments are separated by colon.
                // Examples: /c:1234567 or /P:1234567
                if (firstArgument.Length > 2)
                {
                    //secondArgument = firstArgument.Substring(3).Trim();
                    firstArgument = firstArgument.Substring(0, 2);
                }
                //else if (args.Length > 1)
                //{
                //    secondArgument = args[1];
                //}

                switch (firstArgument)
                {
                    case "/c":  // Configuration mode
                        IsSettingMode = true;
                        return Container.Resolve<MainWindow>();
                        //return Container.Resolve<SettingWindow>();
                    case "/p":  // Preview mode
                        throw new NotImplementedException();
                    case "/s":  // Full-screen mode
                        return Container.Resolve<MainWindow>();
                    default:
                        logger.Error("Startup - Invalid arguments");
                        throw new NotImplementedException();
                }
            }
            else    // No arguments - treat like /c
            {
                logger.Info("Startup - No arguments");
                return Container.Resolve<MainWindow>();
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Page0>();
            containerRegistry.RegisterForNavigation<Page1>();

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
