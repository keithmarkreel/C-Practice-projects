using System;
using System.Collections.Generic;
using System.Linq;

namespace PCparts
{
    class Parts
    {
        public int partID { get; set; }
        public int partPrice { get; set; }
        public string partName { get; set; }

        public Parts(int ID, int Price, string Name)
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
                foreach(PCParts hardware in ComputerParts)
            {
                hardware.DeviceStatus();
            }
            




        }




    }
}