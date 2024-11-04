using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw1
{
    public interface ITransport 
    {
        string Name { get; set;}
        double TankVolume { get; set; }
        public int Weight { get; set;}
        public string Color { get; set; }

        void Start();
        void Stop();
        void Beep();
        void Go();
        void Info();
    }
}