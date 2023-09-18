using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2Uppdaterad
{
    public class KitchenOperation
    {
        public class UseDevices : IMenu
        {
            public void Run(List<KitchenDevices> kitchenDevices)
            {
                Console.WriteLine("Choose the device you want to use:");
                for (int i = 0; i < kitchenDevices.Count; i++)
                {
                    Console.WriteLine($"{i}: {kitchenDevices[i]}");
                }

                if (int.TryParse(Console.ReadLine(), out int userChoice) && userChoice >= 0 && userChoice < kitchenDevices.Count)
                {
                    var selectedDevice = kitchenDevices[userChoice];
                    Console.WriteLine(selectedDevice.IsFunctioning ? $"Using: {selectedDevice}" : $"{selectedDevice} is broken");
                }

                else
                {
                    Console.WriteLine("Invalid choice");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        public class AddDevice : IMenu
        {
            public void Run(List<KitchenDevices> kitchenDevices)
            {
                Console.WriteLine("Enter the type of the device:");
                string type = Console.ReadLine();

                Console.WriteLine("Enter the brand of the device:");
                string brand = Console.ReadLine();

                Console.WriteLine("Is it functioning? (yes/no):");
                string inputString = Console.ReadLine();
                bool isFunctioning = inputString.ToLower() == "yes";

                var device = new KitchenDevices(type, brand, isFunctioning);
                kitchenDevices.Add(device);

                Console.WriteLine("The device was added!");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public class ListDevices : IMenu
        {
            public void Run(List<KitchenDevices> kitchenDevices)
            {
                Console.WriteLine("---KITCHEN DEVICES");
                for (int i = 0; i < kitchenDevices.Count; i++)
                {
                    Console.WriteLine($"{i}: {kitchenDevices[i]}");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        public class RemoveDevice : IMenu
        {
            public void Run(List<KitchenDevices> kitchenDevices)
            {
                Console.WriteLine("Choose which device you want to remove:");
                for (int i = 0; i < kitchenDevices.Count; i++)
                {
                    Console.WriteLine($"{i}: {kitchenDevices[i]}");
                }

                if (int.TryParse(Console.ReadLine(), out int userChoice) && userChoice >= 0 && userChoice < kitchenDevices.Count)
                {
                    var removedDevice = kitchenDevices[userChoice];
                    kitchenDevices.RemoveAt(userChoice);
                    Console.WriteLine($"{removedDevice} was removed");
                }

                else
                {
                    Console.WriteLine("Invalid choice");
                }


            }

        }
    }
}

