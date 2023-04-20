using CustomerServiceSystem.Models;


namespace CustomerServiceSystem.Services;

internal class MenuService
{

    public async Task CreateCaseAsync()
    {
        var customer = new Customer();
        var addCase = new AddCase();


        Console.Write("Ange ditt förnamn:");
        customer.FirstName = Console.ReadLine() ?? "";

        Console.Write("Ange ditt Efternamn:");
        customer.LastName = Console.ReadLine() ?? "";

        Console.Write("Ange din Email:");
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



        // sparar kundärende till databasen

        addCase.CustomerId = await CustomerService.SaveAsync(customer);
        await CaseService.SaveAsync(addCase);
    }

    public async Task ShowAllCasesAsync()
    {
        var cases = await CaseService.GetAllAsync();

        if (cases.Any())
        {
            foreach (Case _case in cases)
            {
                Console.WriteLine($"Ärendenummer: {_case.Id}");
                Console.WriteLine($"Titel: {_case.Title}");
                Console.WriteLine($"Status: {_case.Status}");
                Console.WriteLine($"Comment: {_case.Comment}");
                Console.WriteLine($"Kundnummer: {_case.CustomerId}");
                Console.WriteLine("");
            }
        }
        else
        {
            Console.WriteLine("Det finns inga sparade ärenden.");
            Console.WriteLine("");
        }
    }

    public async Task SearchSpecificCaseAsync()
    {
        Console.Write("Ange ett kundnummer:");
        var customerId = Convert.ToInt32(Console.ReadLine());

        if (customerId != null)
        {
            var cases = await CaseService.GetAsync(customerId);

            if (cases != null)
            {
                Console.WriteLine($"Kundnummer: {cases.CustomerId}");
                Console.WriteLine($"Titel: {cases.Title}");
                Console.WriteLine($"Status: {cases.Status}");
                Console.WriteLine($"Comment: {cases.Comment}.");
                Console.WriteLine($"Ärendenummer: {cases.Id}");
                Console.WriteLine("");

            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Det finns ingen kund med detta kundnummer {customerId}");
                Console.WriteLine("");
            }
        }
    }

    public async Task UpdateCaseStatusAsync()
    {
        Console.Write("Skriv in kundnummer: ");
        var caseId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ändra status på ärende.\n");

        Console.WriteLine("1 - Ej påbörjad");
        Console.WriteLine("2 - Pågående");
        Console.WriteLine("3 - Avslutad");

        var newStatus = "";

        switch (Console.ReadLine())
        {
            case "1":
                 newStatus = "Ej påbörjad";
                break;
            case "2":
                newStatus = "Pågående";
                break;
            case "3":
                newStatus = "Avslutad";
                break;


        }
        var caseService = new CaseService();
        var updatedCase = await caseService.UpdateCaseStatusAsync(caseId, newStatus);





        Console.WriteLine($"Ärende med nr. {updatedCase.Id} har blivit uppdaterad med status: {updatedCase.Status}");
    }

}
