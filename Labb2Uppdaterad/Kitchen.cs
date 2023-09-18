using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Labb2Uppdaterad
{
    public class Kitchen
    {
        private List<KitchenDevices> kitchenDevices;

        public Kitchen()
        {
            kitchenDevices = new List<KitchenDevices>
            {
                new KitchenDevices("Mikrovågsugn", "Siemens", true)
            };
        }

        private void ShowMenu()
        {
            Console.WriteLine("---MENU---");
            Console.WriteLine("1. USE DEVICE");
            Console.WriteLine("2. ADD KITCHEN DEVICE");
            Console.WriteLine("3. LIST KITCHEN DEVICES");
            Console.WriteLine("4. REMOVE KITCHEN DEVICE");
            Console.WriteLine("5. EXIT");
            Console.WriteLine("MAKE YOUR CHOICE");
        }

        public void Choices()
        {
            bool menu = true;

            do
            {
                ShowMenu();
                string userInput = Console.ReadLine();
                Console.Clear();

                switch (userInput)

                {
                    case "1":
                        new KitchenOperation.UseDevices().Run(kitchenDevices);
                        break;
                    case "2":
                        new KitchenOperation.AddDevice().Run(kitchenDevices);
                        break;
                    case "3":
                        new KitchenOperation.ListDevices().Run(kitchenDevices);
                        break;
                    case "4":
                        new KitchenOperation.RemoveDevice().Run(kitchenDevices);
                        break;
                    case "5":
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                }

            } while (menu);
        }
    }
}

