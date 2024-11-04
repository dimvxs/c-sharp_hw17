using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace hw1
{
    public class Train: ILandTransport
    {
    public string Name { get; set; } 
    public double TankVolume { get; set; } 
    public int Wheels {get; set;} 
    public string Color { get; set; }
        
    public int Seats {get; set;} 

    public int Weight {get; set;} 

        public Train(){
            Write("Enter name: ");
            Name = ReadLine();

            Write("Enter Tank volume: ");
            string v = ReadLine();
            double volume = double.Parse(v);
            TankVolume = volume;

            Write("Enter count of wheels: ");
            string w = ReadLine();
            int wheels = int.Parse(w);
            Wheels = wheels;

            Write("Enter color: ");
            Color = ReadLine();

            Write("Enter weight: ");
            string we = ReadLine();
            int weight = int.Parse(we);
            Weight = weight;

            Write("Enter the value of seats: ");
            string s = ReadLine();
            int seats = int.Parse(s);
            Seats = seats;

            
        }

        public void Start(){
            Write($"Train: {Name} is starting \n");
        }

        public void Stop(){
              Write($"Train: {Name} stopped \n");
        }

        public void Beep(){
             Write($"Train: {Name} is beeping! \n");
        }

         public void Go(){
             Write($"Train: {Name} is going! \n");
        }


        public void Info(){
            Write($"Train: {Name} \n");
            Write($"Tank Volume: {TankVolume} \n");
            Write($"Count of wheels: {Wheels} \n");
            Write($"Color: {Color} \n");
            Write($"Weight: {Weight} \n");
            Write($"Seats: {Seats} \n");
        } 
        
    
    }
}