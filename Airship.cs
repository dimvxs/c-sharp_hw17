using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
namespace hw1
{
    public class Airship: IAirTransport
    {
        public string Name { get; set; }
        public double TankVolume { get; set; }
         public int Weight { get; set; }
        public string Color { get; set; }
        public double MaxHeight { get; set; }
        public int FlightDuration { get; set; }


         public Airship(){
            Write("Enter name: ");
            Name = ReadLine();

            Write("Enter Tank volume: ");
            string v = ReadLine();
            double volume = double.Parse(v);
            TankVolume = volume;

        

            Write("Enter color: ");
            Color = ReadLine();

            Write("Enter weight: ");
            string we = ReadLine();
            int weight = int.Parse(we);
            Weight = weight;



            Write("Enter max height of Airship: ");
            string m = ReadLine();
            int max = int.Parse(m);
            MaxHeight = max;


            Write("Enter flight duration of Airship: ");
            string d = ReadLine();
            int duration = int.Parse(d);
            FlightDuration = duration;



            
        }



           public void Start(){
            Write($"Airship: {Name} is starting \n");
        }

        public void Stop(){
              Write($"Airship: {Name} stopped \n");
        }

        public void Beep(){
             Write($"Airship: {Name} is beeping! \n");
        }

         public void Go(){
             Write($"Airship: {Name} is going! \n");
        }

         public void TurbulenceMode(){
                Write($"Airship: {Name} turned on turbulence mode \n");
          }


           public void Landing(){
                Write($"Airship: {Name} is landing \n");
          }

           public void Takeoff(){
                Write($"Airship: {Name} is taking off \n");
          }


        public void Info(){
            Write($"Airship: {Name} \n");
            Write($"Tank Volume: {TankVolume} \n");
            Write($"Color: {Color} \n");
            Write($"Weight: {Weight} \n");
            Write($"Max height: {MaxHeight} \n");
            Write($"Flight duration: {FlightDuration} \n");
        } 
    }
}