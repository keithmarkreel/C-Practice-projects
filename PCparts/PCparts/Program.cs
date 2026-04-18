using System;
using System.Collections.Generic;
using System.Linq;

namespace PCparts
{
    class Parts //CLASS 
    {
        public int partID { get; set; } //FIELD
        public int partPrice { get; set; }
        public string partName { get; set; }

        public Parts(int ID, int Price, string Name) //CONSTRUCTOR
        {
            partID = ID;
            partPrice = Price;
            partName = Name;
        }

        public virtual void DeviceStatus()
        {
            Console.Write("Booting general device");
        }
    }



    class PCParts : Parts
    {
        public string PCPartBrand;

        public PCParts(int ID, int Price, string Name, string Brand) : base(ID,Price, Name)
        {
            PCPartBrand = Brand;
        }

        public override void DeviceStatus()
        {
            
            Console.WriteLine("ID: "+ partID + ". Booting PC hardware");
            
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<PCParts> ComputerParts = new List<PCParts>();
            ComputerParts.Add(new PCParts(1, 2000, "GTX 1080", "NVIDIA"));
            ComputerParts.Add(new PCParts(2, 3000, "GTX 1080", "NVIDIA"));
            ComputerParts.Add(new PCParts(3, 4000, "GTX 1080", "NVIDIA"));
            ComputerParts.Add(new PCParts(4, 5000, "GTX 1080", "NVIDIA"));
            ComputerParts.Add(new PCParts(5, 6000, "GTX 1080", "NVIDIA"));

            IEnumerable<PCParts> PCPartsQuery = //LINQ PCPartsQuery contains the List of Data
                from PCPart in ComputerParts    //PCPart is a variable created so PC
                where PCPart.partPrice > 3000   //
                select PCPart;                  //Program Basically Finds PCParts greater than 3000



            foreach (PCParts hardware in ComputerParts)
            {
                hardware.DeviceStatus();
            }

            foreach (PCParts computer in PCPartsQuery)
            {
                Console.WriteLine(computer.partPrice);
            }
            




        }




    }
}