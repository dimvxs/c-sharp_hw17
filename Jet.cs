using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace hw1
{
    public class Jet: IAirTransport
    {
        
        public string Name { get; set; }
        public double TankVolume { get; set; }
         public int Weight { get; set; }
        public string Color { get; set; }
        public double MaxHeight { get; set; }
       public int HoverSpeed { get; set; }


         public Jet(){
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



            Write("Enter the max height of Jet: ");
            string m = ReadLine();
            int max = int.Parse(m);
            MaxHeight = max;


     Write("Enter the hover speed of Jet: ");
            string h = ReadLine();
            int hovers = int.Parse(h);
            HoverSpeed = hovers;
            
        }



           public void Start(){
            Write($"Jet: {Name} is starting \n");
        }

        public void Stop(){
              Write($"Jet: {Name} stopped \n");
        }

        public void Beep(){
             Write($"Jet: {Name} is beeping! \n");
        }

         public void Go(){
             Write($"Jet: {Name} is going! \n");
        }

         public void TurbulenceMode(){
                Write($"Jet: {Name} turned on turbulence mode \n");
          }


           public void Landing(){
                Write($"Jet: {Name} is landing \n");
          }

           public void Takeoff(){
                Write($"Jet: {Name} is taking off \n");
          }


        public void Info(){
            Write($"Jet: {Name} \n");
            Write($"Tank Volume: {TankVolume} \n");
            Write($"Color: {Color} \n");
            Write($"Weight: {Weight} \n");
            Write($"Max height: {MaxHeight} \n");
            Write($"Hover Speed: {HoverSpeed} \n");
        } 
        
    }
}