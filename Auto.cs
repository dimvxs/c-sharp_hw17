using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using static System.Console;
namespace hw1
{
    public class Auto: ILandTransport
    {

    public string Name { get; set; } 
    public double TankVolume { get; set; } 
    public int Wheels {get; set;} 

    public int Weight { get; set;}
    public string Color { get; set; }

        public Auto(){
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

            
        }

        public void Start(){
            Write($"Car: {Name} is starting \n");
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
            Write($"Car: {Name} \n");
            Write($"Tank Volume: {TankVolume} \n");
            Write($"Count of wheels: {Wheels} \n");
            Write($"Color: {Color} \n");
            Write($"Weight: {Weight} \n");
        } 
        
    }
}