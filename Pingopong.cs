using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace pinger
{
    class Ping
    {
        public delegate void Container();
        public event Container OnPing;
        public void DoPing()
        {
            Console.WriteLine("PING!");
            Thread.Sleep(1000);
            OnPing();
        }
    }

    class Pong
    {
        public delegate void Container();
        public event Container OnPong;
        public void DoPong()
        {
            Console.WriteLine("p-p-p-po pong");
            Thread.Sleep(1000);
            OnPong();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pong Ponger = new Pong();
            Ping Pinger = new Ping();

            Pinger.OnPing += Ponger.DoPong;
            Ponger.OnPong += Pinger.DoPing;

            Pinger.DoPing();
        }
    }
}
