﻿using CustomerServiceSystem.Services;

var menu = new MenuService();
bool menuControll = true;

while (menuControll)
{
    Console.Clear();
    Console.WriteLine("1. Skapa ett nytt ärenden");
    Console.WriteLine("2. Visa alla ärenden");
    Console.WriteLine("3. Sök ärenden");
    Console.WriteLine("4. Avsluta programmet");
    Console.Write("Välj ett av ovan alternativ (1-3): ");


    switch (Console.ReadLine())
    {
        case "1":
            menu.CreateNewCase();
            break;

        case "2":
            menu.ShowAllCases();
            break;

        case "3":
            menu.SearchCase();
            break;

        case "4":
            menuControll = false;
            break;

        default: Console.WriteLine("Välj ett av menyvalen 1-3 för att fortsätta.");
                break;
    }
    Console.ReadKey();
}