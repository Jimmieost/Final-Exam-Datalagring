using CustomerServiceSystem.Models;

namespace CustomerServiceSystem.Services;

internal class MenuService
{
   
    public void CreateNewCase()
    {
        var customer = new Customer();

        Console.Write("Ange ditt förnamn:");
        customer.FirstName = Console.ReadLine() ?? "";

        Console.Write("Ange ditt Efternamn:");
        customer.LastName = Console.ReadLine() ?? "";

        Console.Write("Ange ditt Email:");
        customer.Email = Console.ReadLine() ?? "";

        Console.Write("Ange ditt telefonnummer:");
        customer.PhoneNumber = Console.ReadLine() ?? "";

        Console.Write("Beskriv ditt ärende:");
        customer.Case.Description = Console.ReadLine() ?? "";

        
        // Saving customer case to database
        



    }

    public void ShowAllCases()
    {

    }

    public void SearchCase()
    {

    }


}
