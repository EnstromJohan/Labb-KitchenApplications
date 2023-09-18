using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2Uppdaterad
{
    public class KitchenDevices
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public bool IsFunctioning { get; set; }

        public KitchenDevices(string type, string brand, bool isFunctioning) 
        {
            Type = type;
            Brand = brand;
            IsFunctioning = isFunctioning; 
        }

        public override string ToString()
        {
            return $"{Type}, {Brand}, {(IsFunctioning ? "The device is functioning" : "The device is not functioning")}";
        }

    }
}
