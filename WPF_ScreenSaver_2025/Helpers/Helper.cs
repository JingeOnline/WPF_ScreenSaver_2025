using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using WPF_ScreenSaver_2025.Models;

namespace WPF_ScreenSaver_2025.Helpers
{
    public class Helper
    {

        public static Action SettingBarAlignmentChanged {  get; set; }

        #region 读写页面布局的配置文件
        private static readonly string SavingPath = "WebView2Layouts.json";
        public static void SaveToJsonFile(IEnumerable<WebViewModel> models)
        {
            string jsonString = JsonSerializer.Serialize(models);
            File.WriteAllText(SavingPath, jsonString);
        }
        public static IEnumerable<WebViewModel> ReadJosnFile()
        {
            string jsonString=File.ReadAllText(SavingPath);
            return JsonSerializer.Deserialize<IEnumerable<WebViewModel>>(jsonString);
        }
        #endregion



        public static System.Drawing.Color Color_Transparent= System.Drawing.Color.Transparent;
        public static System.Drawing.Color Color_Gray = System.Drawing.Color.FromArgb(255,28,28,28);
        /// <summary>
        /// 设定模式下背景颜色为灰色，运行状态下背景颜色为透明
        /// </summary>
        public static System.Drawing.Color WvBgColor
        {
            get
            {
                //return System.Drawing.Color.Transparent;
                if (App.IsSettingMode)
                {
                    return Color_Gray;
                }
                else
                {
                    return Color_Transparent;
                }
            }
        }
    }
}
