using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw1
{
    public interface ILandTransport: ITransport //наземный транспорт
    {
    public int Wheels {get; set;} 
    public string Color { get; set; }
        
    }
}