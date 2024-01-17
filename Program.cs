using System;

class DiceSimulator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? "); // Receive input from user 
        
        int numberOfRolls = int.Parse(Console.ReadLine()); //Change value to int so math works 

        DiceRoller diceRoller = new DiceRoller(); //Creating new instance of the class 
        int[] results = diceRoller.SimulateRolls(numberOfRolls); // Calling the method

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i] * 100 / numberOfRolls;
            Console.WriteLine($"{i}: {new string('*', percentage)}");
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}

class DiceRoller
{
    private int[] rollCounts; //Array of integers to keep track of rolls

    public int[] SimulateRolls(int numberOfRolls)
    {
        rollCounts = new int[13]; // 13 because max result is 12

        Random random = new Random(); //Variable that will store the number 1-6

        for (int i = 0; i < numberOfRolls; i++) //Randonmly throw the dice 
        {
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;

            rollCounts[sum]++; //Add how many times the dice where rolled 
        }

        return rollCounts;
    }
}
