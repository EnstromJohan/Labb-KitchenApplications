



Kitchen kitchen = new Kitchen();

kitchen.DisplayApplication();

public class Kitchen
{
    string type { get; set; }
    string brand { get; set; }
    bool isFunctioning { get; set; }

    bool menu = true;

    List<string> KitchenAppliances = new List<string>() { "Microvågsugn, Siemens" };

    void Menu()
    {
        Console.WriteLine("===HUVUDMENY===\n" +
            "1. ANVÄND KÖKSAPPARAT\n" +
            "2. LÄGG TILL KÖKSAPPARAT\n" +
            "3. LISTA KÖKSAPPARAT\n" +
            "4. TA BORT KÖKSAPPARAT\n" +
            "5. AVSLUTA");
            Console.Write("GÖR DITT VAL >> ");
        
    }

    public void Choices()
    {
        string userInput = Console.ReadLine();
        Console.Clear();
        switch (userInput)
        {
            case "1":
                UseAppliance(KitchenAppliances);
                break;
            case "2":
                AddAppliance
                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                break;
            default:
                Console.WriteLine("Ogiltigt val");
                Console.ReadKey();
                Console.Clear();
                return;

        }
    }

    void UseAppliance(List<string> KitchenAppliances)
    {
        Console.WriteLine("VÄLJ VILKEN DU VILL ANVÄNDA");
        int i = 0;
        foreach (var item in KitchenAppliances)
        {
            Console.WriteLine($"{i}: {item}");
            i++;
        }

        int userChoice = Convert.ToInt32(Console.ReadLine());
        var listChoice = KitchenAppliances.ElementAt(userChoice);

        if (isFunctioning = false)
        {
            Console.WriteLine("APPARATEN ÄR TRASIG");
        }
        else
        {
            Console.WriteLine($"DU ANVÄNDER: {listChoice}");
        }

        Console.ReadKey();
        Console.Clear();
    }

    void AddAppliance(List<string> KitchenAppliances)
    {
        Console.WriteLine("VILKEN TYP?");
        type = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("VILKET MÄRKE?");
        brand = Console.ReadLine();
        Console.Clear();

        isFunctioning = false;
        Console.WriteLine("FUNGERARD DEN? j/n");
        string answer = Console.ReadLine().Trim().ToLower();

        if (answer == "j")
        {
            isFunctioning = true;
            KitchenAppliances.Add(type)
        }
    }

    public void DisplayApplication()
    {
        do
        {
            Menu();
            Choices();
        }
        while (menu);
    }
}