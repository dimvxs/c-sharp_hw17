using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace hw1
{
    public class MotorShip: IWaterTransport
    {
        public string Name { get; set; }
        public double TankVolume { get; set; }
        public int PassengersCount { get; set; }
        public string Color { get; set; }
        public double AnchorWeight { get; set;}
        public int Weight {get; set;} 
        public int FuelEfficiency {get; set;} 
        


  public MotorShip(){
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


            Write("Enter the FuelEfficiency: ");
            string fu = ReadLine();
            int fuel = int.Parse(fu);
            FuelEfficiency = fuel;

            
        }

        public void Start(){
            Write($"Motor Ship: {Name} is starting \n");
        }

        public void Stop(){
              Write($"Motor Ship: {Name} stopped \n");
        }

        public void Beep(){
             Write($"Motor Ship: {Name} is beeping! \n");
        }

         public void Go(){
             Write($"Motor Ship: {Name} is going! \n");
        }

        public void dropAnchor(){
              Write($"Motor Ship: {Name} dropped anchor \n");
        }

        public void checkWeight(){
            if(AnchorWeight < 500){
                  Write($"Motor Ship: {Name} anchor  weight within normal limits \n");
            }
            else{
                Write($"Motor Ship: {Name} anchor  weight exceds the norm \n");
            }
        }



        public void Info(){
            Write($"Motor Ship: {Name} \n");
            Write($"Tank Volume: {TankVolume} \n");
            Write($"Color: {Color} \n");
            Write($"Weight: {Weight} \n");
            Write($"Passengers count: {PassengersCount} \n");
            Write($"Anchor weight: {AnchorWeight} \n");
            Write($"Anchor weight: {FuelEfficiency} \n");
        } 
        
    }
}