// See https://aka.ms/new-console-template for more information
   
using System;
using System.ComponentModel.Design;


class pet_creation
{
    static void Main()
    {
        Console.WriteLine("choose pets from the given list:");
        Console.WriteLine("1:RABBIT");
        Console.WriteLine("2:CAT");
        Console.WriteLine("3:PARROT");
        string pet_type = Console.ReadLine();
        Console.WriteLine("what would you like to name your pet");
        string pet_name = Console.ReadLine();
        Console.WriteLine("hi all,welcome to the pet simulator");
        int hunger = 5;
        int happiness = 7;
        int health = 5;
        
        while (true)
        {
            Console.WriteLine($"\n{pet_name}s status");
            Console.WriteLine($"Hunger:{hunger}");
            Console.WriteLine($"Happiness:{happiness}");
            Console.WriteLine($"Health:{health}");
            Console.WriteLine("\n choose an action");
            Console.WriteLine("1:Feed");
            Console.WriteLine("2:Play");
            Console.WriteLine("3.Rest");
            Console.WriteLine("4.Exit");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    hunger--;
                    health++;
                    Console.WriteLine($"{pet_name}is fed[hunger decreased health slightly increased]");
                    break;
                    case "2":
                    happiness++;
                    hunger++;
                    Console.WriteLine($"{pet_name}played[happiness increased hunger slightly increased]");
                    break;
                    case"3":
                    health++;   
                    happiness--;
                    Console.WriteLine($"{pet_name} rested [health increased happiness decreased]");
                    break;
                    case "4":
                    Console.WriteLine($"{pet_name} CU AGAIN");
                    return;
                    default:
                    Console.WriteLine("the choice is invalid 1,2,3or4");
                    break;
                    hunger++;
                    happiness--;
            }


        }
    } }