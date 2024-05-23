using System;

Console.WriteLine("Welcome to the program! Here is the main menu.");

do
{
    // Main menu
    Console.WriteLine("Choose one of the numbers from 0 to 4 to test different functions:");
    Console.WriteLine("1. Check the age to see the price");
    Console.WriteLine("2. Calculate the group price");
    Console.WriteLine("3. Repeat anything 10 times");
    Console.WriteLine("4. Find the third word");
    Console.WriteLine("0. Exit the program");
    var input = Console.ReadLine()!;

    switch (input)
    {
        case "1":
            // Check the age and show the price according to the conditions
            Console.WriteLine("");
            Console.WriteLine("If you want to buy a cinema ticket, please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 5 || age > 100)
                Console.WriteLine("You can go to the cinema for free");  // extra conditions for very little children and very old people
            else if (age < 20)
                Console.WriteLine("Youth ticket: 80 SEK");
            else if (age > 64)
                Console.WriteLine("Pensioner ticket: 90 SEK");
            else
                Console.WriteLine("Standard ticket: 120 SEK");
            Console.WriteLine("");
            break;

        case "2":
            // Ask for a number of people in a group and calculate the total price
            Console.WriteLine("");
            Console.WriteLine("Let's calculate the total price for your group. How many people are going to the cinema?");
            int amountOfPeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ok, now enter age for each person in your group.");
            int individualPrice = 0;
            int groupPrice = 0;
            for (int i = 0; i < amountOfPeople; i++)
            {
                Console.WriteLine("Age: ");
                int personAge = Convert.ToInt32(Console.ReadLine());
                if (personAge < 5 || personAge > 100)
                    individualPrice = 0;
                else if (personAge < 20)
                    individualPrice = 80;
                else if (personAge > 64)
                    individualPrice = 90;
                else
                    individualPrice = 120;
                groupPrice += individualPrice;
            }
            Console.WriteLine($"Number of people: {amountOfPeople}. Total price: {groupPrice} SEK.");
            Console.WriteLine("");
            break;

        case "3":
            // Repeat the user input for 10 times in a row
            Console.WriteLine(""); 
            Console.WriteLine("Please type something. The program will repeat it 10 times.");
            string userInput = Console.ReadLine();
            Console.WriteLine("Thank you! Here it is, repeated 10 times: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(userInput);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            break;

        case "4":
            // Find the third word in the user input
            Console.WriteLine(""); 
            Console.WriteLine("Please enter 3 words separated by spaces. After that the program will show you the third word.");
            string threeWords = Console.ReadLine();
            string[] parts = threeWords.Split(' ', StringSplitOptions.RemoveEmptyEntries); // works even if there are multiple spaces
            string thirdWord = parts[2];
            Console.WriteLine("The third word is " + thirdWord);
            Console.WriteLine("");
            break;

        case "0":
            // Exit the application
            Environment.Exit(0);
            break;

        default:
            // Wrong input in the main menu
            Console.WriteLine("Incorrect. Please enter one of the numbers from 0 to 4.");
            break;
    }


} while (true);
