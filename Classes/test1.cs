using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace Autoclickerro.Classes
{
    public class test1
    {
          
        private static System.Timers.Timer _timer = new System.Timers.Timer();
        private static List<DateTime> _results = new List<DateTime>();
        private static int _limit;
        public static void start(int limit)
        {

            _limit = limit;
            //var _timer =  new System.Timers.Timer();
 
            _timer.Interval = 1100;
            _timer.Elapsed += _timer_Elapsed;
           
            _timer.AutoReset = true;
            _timer.Enabled = true;

           
            Debug.WriteLine("Timer.Start()");
            
        }

        public static void stop()
        {
            _timer.Enabled = false;
            _timer.Stop();
            _limit = 0;
            Debug.WriteLine("Timer.Stop()");
        }
        private static void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Debug.WriteLine("Tick: {0} in {1}", e.SignalTime, _limit);
            _limit--;
            if (_limit <= 0) stop();
            
        }
    }
    
}