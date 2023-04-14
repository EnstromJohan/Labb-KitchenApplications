



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
            "5. STÄNG MENY");
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
                AddAppliance(KitchenAppliances);
                break;
            case "3":
                ListAppliances(KitchenAppliances);
                break;
            case "4":
                RemoveAppliances(KitchenAppliances);
                break;
            case "5":
                EndApplication(KitchenAppliances);
                menu = false;
                break;
                break;
            default:
                Console.WriteLine("OGILTIGT VAL");
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

        if (isFunctioning == false)
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
            KitchenAppliances.Add(type + "," + brand);
            Console.WriteLine("TILLAGD");
        }
        else
        {
            KitchenAppliances.Add(type + ", " + brand);
            Console.WriteLine("TILLAGD");
        }
        Console.ReadKey();
        Console.Clear();
    }

    void ListAppliances(List<string> KitchenAppliances)
    {
        Console.WriteLine("===KÖKSAPPARATER===");
        int i = 0;
        foreach (var item in KitchenAppliances)
        {
            Console.WriteLine($"{i}: {item}");
            i++;
        }
    }

    void RemoveAppliances(List<string> KitchenAppliances)
    {
        Console.WriteLine("VÄLJ VILKEN DU VILL TA BORT\n>>");
        int i = 0;
        foreach (var item in KitchenAppliances)
        {
            Console.WriteLine($"{i}: {item}");
            i++;
        }
        int removed = Convert.ToInt32(Console.ReadLine());
        var list = KitchenAppliances.ElementAt(removed);
        KitchenAppliances.Remove(list);
        Console.WriteLine($"{list} TOGS BORT");
    }

    void EndApplication(List<string> KitchenAppliances)
    {
        return;
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

