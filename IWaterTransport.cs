using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw1
{
    public interface IWaterTransport: ITransport //водный транспорт
    {

        public int PassengersCount { get; set;}
        public double AnchorWeight { get; set;}

        void checkWeight();
        void dropAnchor();
        
    }
}