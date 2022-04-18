using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Delegat_i_sob
{
    internal class Timer
    {
        public void Start() 
        {
            for(int i = 0; i<99999; i++) 
            {
                Thread.Sleep(1000);
                
            }
        }

        public delegate void TimeChange(int sec);

        public event TimeChange TimeChangeEvent;
    }

    internal class Clock
    {
        public void ParseTime(int sec) 
        {
            Console.WriteLine($"{sec} Секунда");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            Clock clock = new Clock();

            timer.TimeChangeEvent += clock.ParseTime;

            timer.Start();
        }
    }
}
