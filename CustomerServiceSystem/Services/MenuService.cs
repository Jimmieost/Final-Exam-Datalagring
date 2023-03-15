using CustomerServiceSystem.Models;

namespace CustomerServiceSystem.Services;

internal class MenuService
{
   
    public async Task SaveCaseAsync()
    {
        var customer = new Customer();
        var addCase = new AddCase(); 


        Console.Write("Ange ditt förnamn:");
        customer.FirstName = Console.ReadLine() ?? "";

        Console.Write("Ange ditt Efternamn:");
        customer.LastName = Console.ReadLine() ?? "";

        Console.Write("Ange ditt Email:");
        customer.Email = Console.ReadLine() ?? "";

        Console.Write("Ange ditt telefonnummer:");
        customer.PhoneNumber = Console.ReadLine() ?? "";
        
        Console.Write("Ange din gatuadress:");
        customer.StreetName = Console.ReadLine() ?? "";
        
        Console.Write("Ange ditt postnummer:");
        customer.PostalCode = Console.ReadLine() ?? "";
        
        Console.Write("Ange din ort:");
        customer.City = Console.ReadLine() ?? "";

        Console.Write("Titel på ärendet:");
        addCase.Title = Console.ReadLine() ?? "";

        Console.Write("Beskriv ditt ärende:");
        addCase.Description = Console.ReadLine() ?? "";



        // Saving customer case to database
        addCase.CustomerId = await CustomerService.SaveAsync(customer);
        await CaseService.SaveAsync(addCase);   
        



    }

    public void ShowAllCases()
    {

    }

    public void SearchCase()
    {

    }


}
