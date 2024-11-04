using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace hw1
{
    public class Carriage: ILandTransport
    {
    public string Name { get; set; } 
    public double TankVolume { get; set; } 
    public int Wheels {get; set;} 
    public string Color { get; set; }
        
    public int Seats {get; set;} 

    public int Weight {get; set;} 

    public int HorseCount {get; set;}

    public bool HorseHealth {get; set;}

    
        public Carriage(){
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

            Write("Enter the value of horses: ");
            string h = ReadLine();
            int horses = int.Parse(h);
            HorseCount = horses;


            
        }

        public void Start(){
            Write($"Train: {Name} is starting \n");
        }

        public void Stop(){
              Write($"Car: {Name} stopped \n");
        }

        public void Beep(){
             Write($"Car: {Name} is beeping! \n");
        }

         public void Go(){
             Write($"Car: {Name} is going! \n");
        }


        public void Info(){
            Write($"Carriage: {Name} \n");
            Write($"Tank Volume: {TankVolume} \n");
            Write($"Count of wheels: {Wheels} \n");
            Write($"Color: {Color} \n");
            Write($"Weight: {Weight} \n");
            Write($"Seats: {Seats} \n");
            Write($"Horse count: {HorseCount} \n");
            Write($"Horse health: {HorseHealth} \n");
        } 
        
    
        
    }
}