using CustomerServiceSystem.Services;

var menu = new MenuService();
bool menuControll = true;



while (menuControll)
{
    Console.Clear();
    Console.WriteLine("1. Skapa ett nytt ärende");
    Console.WriteLine("2. Visa alla ärenden");
    Console.WriteLine("3. Sök specifikt ärende");
    Console.WriteLine("4. Uppdatera ärendestatus");
    Console.WriteLine("5. Avsluta programmet");
    Console.Write("Välj ett av ovan alternativ (1-3): ");


    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            await menu.CreateCaseAsync(); 
            break;

        case "2":
            Console.Clear();
            await menu.ShowAllCasesAsync();
            break;

        case "3":
            Console.Clear();
            await menu.SearchSpecificCaseAsync();
            break;

        case "4":
            Console.Clear();
            await menu.UpdateCaseStatusAsync();
            break;

        case "5":
            Console.Clear();
            menuControll = false;
            break;

        default: Console.WriteLine("Välj ett av menyvalen 1-4 för att fortsätta.");
                break;
    }
    Console.ReadKey();
}