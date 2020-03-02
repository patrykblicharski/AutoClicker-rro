using System;
using System.Runtime.InteropServices;

namespace Autoclickerro.Classes
{
    public abstract class aClicker
    {
        public static readonly int MOUSEEVENTF_LEFTDOWN = 2;
        public static readonly int MOUSEEVENTF_LEFTUP = 4;
        public static readonly int MOUSEEVENTF_RIGHTDOWN = 8;
        public static readonly int MOUSEEVENTF_RIGHTUP = 16;
        public static readonly int MOUSEEVENTF_MIDDLEUP = 32;
        public static readonly int MOUSEEVENTF_MIDDLEDOWN = 64;
        //input type constant
        public static readonly int INPUT_MOUSE = 0;

        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        public  struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        };

        [DllImport("User32.dll", SetLastError = true)]
        public static extern int SendInput(int nInputs, ref fMain.INPUT pInputs, int cbSize);


        protected abstract void clickSendInput();

    }
}