using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;


namespace hw1
{
    public interface IAirTransport: ITransport //воздушный транспорт
    {
        
        public double MaxHeight { get; set; }
        void TurbulenceMode();
        void Landing();
        void Takeoff();
        
        
    }
}