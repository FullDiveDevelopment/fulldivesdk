using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Windows.Security.Isolation;
using static System.Windows.Window;
using static System.Windows.WindowState;

namespace FullDiveSDK.Windows
{
    internal class Windows
    {
        public static int AppWidth;
        public static int AppHeight;

        

        public static Windows WindowApp = new Windows();
        public static void Window(int ScreenWidth, int ScreenHeight)
        {
            AppHeight = ScreenHeight;
            AppWidth = ScreenWidth;

            ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
        }

        public static void Window(string? AppName)
        {
            AppName.DefaultIfEmpty();
        }

        public bool IsMaximized { get; set; }
        public bool IsMinimized { get; set; }
        public bool IsFullscreen { get; set; }
        public bool IsBorderless { get; set; }
        public bool IsResizable { get; set; }
        public bool IsMovable { get; set; }
        public bool IsCloseable { get; set; }
        public bool IsDraggable { get; set; }
        public bool IsFocusable { get; set; }
    }
}
