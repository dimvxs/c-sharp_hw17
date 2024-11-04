using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace hw1
{
    public class Airplane: IAirTransport
    {
        public string Name { get; set; }
        public double TankVolume { get; set; }
         public int Weight { get; set; }
        public string Color { get; set; }
        public double MaxHeight { get; set; }




        public Airplane(){
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



            Write("Enter the max height of airplane: ");
            string m = ReadLine();
            int max = int.Parse(m);
            MaxHeight = max;

            
        }



           public void Start(){
            Write($"Airplane: {Name} is starting \n");
        }

        public void Stop(){
              Write($"Airplane: {Name} stopped \n");
        }

        public void Beep(){
             Write($"Airplane: {Name} is beeping! \n");
        }

         public void Go(){
             Write($"Airplane: {Name} is going! \n");
        }

         public void TurbulenceMode(){
                Write($"Airplane: {Name} turned on turbulence mode \n");
          }


           public void Landing(){
                Write($"Airplane: {Name} is landing \n");
          }

           public void Takeoff(){
                Write($"Airplane: {Name} is taking off \n");
          }


        public void Info(){
            Write($"Airplane: {Name} \n");
            Write($"Tank Volume: {TankVolume} \n");
            Write($"Color: {Color} \n");
            Write($"Weight: {Weight} \n");
            Write($"Max height: {MaxHeight} \n");
        } 
        

        
    }
}