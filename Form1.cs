using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autoclickerro.Properties;

//icon by Freepik
namespace Autoclickerro
{
    public partial class fMain : Form
    {
       


        const int MOUSEEVENTF_LEFTDOWN = 2;
        const int MOUSEEVENTF_LEFTUP = 4;
        const int MOUSEEVENTF_RIGHTDOWN = 8;
        const int MOUSEEVENTF_RIGHTUP = 16;
        const int MOUSEEVENTF_MIDDLEUP = 32;
        const int MOUSEEVENTF_MIDDLEDOWN = 64;
        //input type constant
        const int INPUT_MOUSE = 0;

        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        public struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        };

        [DllImport("User32.dll", SetLastError = true)]
        public static extern int SendInput(int nInputs, ref INPUT pInputs, int cbSize);
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public const int START_HOTKEY = 1;
        public const int STOP_HOTKEY = 2;
        public const int SELECT_HOTKEY = 3;

        bool clickatcursor = true;
        private int clickamount = 0;
        private int currentclick = 1;
        Point clickLocation = new Point(0, 0);

        public fMain()
        {
            InitializeComponent();

            timesText.Text = Properties.Settings.Default.ClickTimesSave;
            intervalText.Text = Properties.Settings.Default.ClickIntervalSave;


            //Try to SET combo box index last selected mouse button to use
            try
            {
                selectbuttonCombo.SelectedIndex = Settings.Default.ButonSelSave;
            }
            catch
            {
                selectbuttonCombo.SelectedIndex = 0;
            }

            //Try to SET combo box index last selected type of click to use
            try
            {
                clicktypeCombo.SelectedIndex = Settings.Default.ClickTypeSave;
            }
            catch
            {
                clicktypeCombo.SelectedIndex = 0;
            }


            //Set mode of getting cords of mouse position

            if (Properties.Settings.Default.CursorFixedSave == false)
            {
                rbtnByCursor.Checked = true;
            }
            else
            {
                rbtnByFixed.Checked = true;
            }

            //Restore last saved point position
            clickLocation = Properties.Settings.Default.PointCordsSave;
            string clickLocationStr = clickLocation.ToString();
            labelCords.Text = (clickLocationStr.Remove(clickLocationStr.Length - 1)).Remove(0, 1);
            //
            //     Register global hotkeys
            //
            RegisterHotKey(this.Handle, START_HOTKEY, 0, Properties.Settings.Default.StartHotkey);
            RegisterHotKey(this.Handle, STOP_HOTKEY, 0, Properties.Settings.Default.StopHotKey);
            RegisterHotKey(this.Handle, SELECT_HOTKEY, 0, Properties.Settings.Default.SelectHotKey);
            //

            //Labels injection
            updateLabelKeys();

        }

        public void updateLabelKeys()
        {
            
            btnStart.Text =
                "Start (" + ((Keys)Enum.Parse(typeof(Keys), Properties.Settings.Default.StartHotkey.ToString()))
                .ToString() + ")";
            btnStop.Text =
                "Stop (" + ((Keys)Enum.Parse(typeof(Keys), Properties.Settings.Default.StopHotKey.ToString()))
                .ToString() + ")";
            labelFixed.Text = "(Press " + ((Keys)Enum.Parse(typeof(Keys), Properties.Settings.Default.SelectHotKey.ToString())).ToString() + " to Set) :";
        }

        protected override void WndProc(ref Message m)
        {

            //catch global hotkey pressed


            if (m.Msg == 0x0312 && m.WParam.ToInt32() == START_HOTKEY)
            {
                start();
            }else if (m.Msg == 0x0312 && m.WParam.ToInt32() == STOP_HOTKEY)
            {
                stop();
            }else if (m.Msg == 0x0312 && m.WParam.ToInt32() == SELECT_HOTKEY)
            {
                clickLocation = Cursor.Position;
                Properties.Settings.Default.PointCordsSave = clickLocation;
                Properties.Settings.Default.Save();
                string locationStr = clickLocation.ToString();
                labelCords.Text = (locationStr.Remove(locationStr.Length - 1)).Remove(0, 1);
            }
            //------------------------------
            base.WndProc(ref m);
        }


        public void clickSendInput()
        {
            int clickbutton = selectbuttonCombo.SelectedIndex;
            int typeofclick = clicktypeCombo.SelectedIndex + 1;
            while (typeofclick > 0)
            {
                //SET up the input struct and fill it for the mouse down
                INPUT i = new INPUT();
                i.type = INPUT_MOUSE;
                i.mi.dx = 0;
                i.mi.dy = 0;
                if (clickbutton == 0)
                {
                    i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;

                }
                else if (clickbutton == 1)
                {
                    i.mi.dwFlags = MOUSEEVENTF_MIDDLEDOWN;
                }
                else if (clickbutton == 2)
                {
                    i.mi.dwFlags = MOUSEEVENTF_RIGHTDOWN;
                }
                else
                {
                    i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
                }

                i.mi.dwExtraInfo = IntPtr.Zero;
                i.mi.mouseData = 0;
                i.mi.time = 0;
                
                //SENDING INPUT
                SendInput(1, ref i, Marshal.SizeOf((i)));


                //SET IMPUT FOR MOUSE UP AND SEND IT
                if (clickbutton == 0)
                {
                    i.mi.dwFlags = MOUSEEVENTF_LEFTUP;

                }
                else if (clickbutton == 1)
                {
                    i.mi.dwFlags = MOUSEEVENTF_MIDDLEUP;
                }
                else if (clickbutton == 2)
                {
                    i.mi.dwFlags = MOUSEEVENTF_RIGHTUP;
                }
                else
                {
                    i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
                }

                SendInput(1, ref i, Marshal.SizeOf(i));
                typeofclick--;



            }
        }


        public void start()
        {
            if (ClickTiicker.Enabled == true)
            {
                MessageBox.Show("AutoClickerro already running", "Already running");
            }
            else
            {
                bool interval_error = false;
                bool times_error = false;
                int timerinterv = 1000;
                currentclick = 0;

                try
                {
                    timerinterv = Convert.ToInt32(intervalText.Text);
                }
                catch
                {
                    interval_error = true;
                }

                try
                {
                    clickamount = Convert.ToInt32(timesText.Text);
                }
                catch
                {
                    times_error = true;
                }


                if (interval_error == false)
                {
                    if (times_error == false)
                    {
                        if (rbtnByCursor.Checked == true)
                        {
                            clickatcursor = true;
                        }
                        else
                        {
                            clickatcursor = false;
                        }

                        WorkingStatusLabel.Text = "Clicking.....";
                        WorkingStatusLabel.ForeColor = Color.Green;

                        //dissable buttons
                        rbtnByCursor.Enabled = false;
                        rbtnByFixed.Enabled = false;
                        timesText.Enabled = false;
                        intervalText.Enabled = false;

                        clicktypeCombo.Enabled = false;
                        selectbuttonCombo.Enabled = false;
                        btnStart.Enabled = false;

                        ClickTiicker.Interval = timerinterv;
                        ClickTiicker.Start();

                    }
                    else
                    {
                        MessageBox.Show("Invalid times to click entered", "Invalid click amount");

                    }
                }
                else
                {
                    MessageBox.Show("Invalid interval entered", "Invalid interval");
                }

            }
        }

        public void stop()
        {
            if (ClickTiicker.Enabled == true)
            {
                rbtnByCursor.Enabled = true;
                rbtnByFixed.Enabled = true;
                timesText.Enabled = true;
                intervalText.Enabled = true;

                clicktypeCombo.Enabled = true;
                selectbuttonCombo.Enabled = true;
                btnStart.Enabled = true;
                ClickTiicker.Stop();
                WorkingStatusLabel.Text = "Not Clicking";
                WorkingStatusLabel.ForeColor = Color.Red;
                
            }
            else
            {
                MessageBox.Show("AutoClicker is not running", "Not running");
            }

        }

        int i = 0;

        private void ClickTiicker_Tick(object sender, EventArgs e)
        {
            
            label7.Text = i++.ToString();
            if (clickamount == 0)
            {
                if (clickatcursor == true)
                {
                    clickSendInput();
                }
                else
                {
                    Cursor.Position = clickLocation;
                    clickSendInput();
                }
            }
            else
            {
                if (clickatcursor == true)
                {
                    clickSendInput();
                }
                else
                {
                    Cursor.Position = clickLocation;
                    clickSendInput();
                }
                currentclick++;
                if (currentclick == clickamount)
                {
                    clickSendInput();
                }
            }
        }




                private void btnStart_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start();
        }

        private void timesText_KeyPress(object sender, KeyPressEventArgs e)
        {//check if input is number or remove
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void intervalText_KeyPress(object sender, KeyPressEventArgs e)
        {//check if input is number or remove
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void timesText_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClickTimesSave = timesText.Text;
            Properties.Settings.Default.Save();

        }

        private void intervalText_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClickIntervalSave = intervalText.Text;
            Properties.Settings.Default.Save();

        }

        private void selectbuttonCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClickTypeSave = clicktypeCombo.SelectedIndex;
            Properties.Settings.Default.Save();

        }

        private void rbtnByCursor_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CursorFixedSave = false;
            Properties.Settings.Default.Save();

        }

        private void rbtnByFixed_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CursorFixedSave = true;
            Properties.Settings.Default.Save();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop();
        }
    }
}
