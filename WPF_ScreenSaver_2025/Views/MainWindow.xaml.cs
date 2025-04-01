using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPF_ScreenSaver_2025.ViewModels;

namespace WPF_ScreenSaver_2025.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);
        //private MainWindowViewModel _VM;
        public MainWindow()
        {
            InitializeComponent();
            if (!App.IsSettingMode)
            {
                Cursor = Cursors.None;  //隐藏鼠标
                SetCursorPos(0, 0);  //由于WebView2上隐藏鼠标不起作用，所以需要在启动时候把鼠标移到WebView2外部。
                Topmost = true; //至于所有程序的最顶层
                DetectMouseMove();
            }

        }


        private Point mouseLocation;

        /// <summary>
        /// 检测鼠标移动，通过轮询鼠标的位置，而不是使用事件
        /// </summary>
        /// <returns></returns>
        private async Task DetectMouseMove()
        {
            //while (true)
            //{
            //    Point mouseLocation_updated = Mouse.GetPosition(this);
            //    await Task.Delay(200);
            //    //Debug.WriteLine("run at "+DateTime.Now+ mouseLocation_updated.X+", "+mouseLocation_updated.Y);
            //    if (mouseLocation.X == 0 && mouseLocation.Y == 0)
            //    {
            //        mouseLocation = mouseLocation_updated;
            //    }
            //    else
            //    {
            //        if (!mouseLocation.Equals(mouseLocation_updated))
            //        {
            //            Application.Current.Shutdown();
            //        }
            //    }
            //}
        }

        /// <summary>
        /// 检测键盘被按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //Application.Current.Shutdown();
        }

        /// <summary>
        /// 检测鼠标被按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Application.Current.Shutdown();
            //Debug.WriteLine((ContentRegion.Content as Control).ToString());
            
        }

    }
}
