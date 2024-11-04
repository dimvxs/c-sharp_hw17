using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace hw1
{
    public class Boat: IWaterTransport
    {
        public string Name { get; set; }
        public double TankVolume { get; set; }
        public int PassengersCount { get; set; }
        public string Color { get; set; }
        public double AnchorWeight { get; set;}
        public int Weight {get; set;} 
        public int OarsCount { get; set; }
        public Boat(){
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

            Write("Enter the count of passengers: ");
            string p = ReadLine();
            int pass = int.Parse(p);
            PassengersCount = pass;



            Write("Enter the weight of anchor: ");
            string a = ReadLine();
            int anchor = int.Parse(a);
            AnchorWeight = anchor;



            Write("Enter the count of oars: ");
            string o = ReadLine();
            int oars = int.Parse(o);
            OarsCount = oars;
            
        }

        public void Start(){
            Write($"Boat: {Name} is starting \n");
        }

        public void Stop(){
              Write($"Boat: {Name} stopped \n");
        }

        public void Beep(){
             Write($"Boat: {Name} is beeping! \n");
        }

         public void Go(){
             Write($"Boat: {Name} is going! \n");
        }

        public void dropAnchor(){
              Write($"Boat: {Name} dropped anchor \n");
        }

        public void checkWeight(){
            if(AnchorWeight < 500){
                  Write($"Boat: {Name} anchor  weight within normal limits \n");
            }
            else{
                Write($"Boat: {Name} anchor  weight exceds the norm \n");
            }
        }



        public void Info(){
            Write($"Boat: {Name} \n");
            Write($"Tank Volume: {TankVolume} \n");
            Write($"Color: {Color} \n");
            Write($"Weight: {Weight} \n");
            Write($"Passengers count: {PassengersCount} \n");
            Write($"Anchor weight: {AnchorWeight} \n");
            Write($"Oars count: {OarsCount} \n");
        } 
        

    
    }
}