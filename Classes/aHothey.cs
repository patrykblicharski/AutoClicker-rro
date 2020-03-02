using System;
using System.Runtime.InteropServices;

namespace Autoclickerro.Classes
{
    public abstract class aHothey
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public const int START_HOTKEY = 1;
        public const int STOP_HOTKEY = 2;
        public const int SELECT_HOTKEY = 3;

    }
}