using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WPF_ScreenSaver_2025.Models;

namespace WPF_ScreenSaver_2025.Helpers
{
    public class Helper
    {
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

        /// <summary>
        /// 设定模式下背景颜色为灰色，运行状态下背景颜色为透明
        /// </summary>
        public static System.Drawing.Color WvBgColor
        {
            get
            {
                return System.Drawing.Color.Transparent;
                if (App.IsSettingMode)
                {
                    return System.Drawing.Color.Gray;
                }
                else
                {
                    return System.Drawing.Color.Transparent;
                }
            }
        }
    }
}
