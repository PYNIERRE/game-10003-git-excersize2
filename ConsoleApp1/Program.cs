using System;
using System.Security.AccessControl;
public class Program
{
    public static void Main()
    {
        int value = 1; //you're now at the start
        
        // start
        if (value == 1)
        {
            Console.WriteLine("You find a fork in the road.");
            Console.WriteLine("Do you go LEFT for the town, STRAIGHT for the fields, Or do you head RIGHT for the mountains?");

            string input = Console.ReadLine();
            if (input == "left") //all the inputs
            {
                value = 2; //the condition is now waiting for your response
                Console.WriteLine("You find people. Awesome! Head back to the FORK to continue.");
            }
            else if (input == "right")
            {
                value = 2;
                Console.WriteLine("You find mountain goats. Awesome! Head back to the FORK to continue.");
            }
            else if (input == "straight")
            {
                value = 2;
                Console.WriteLine("It's beautiful.. So many flowers. Head back to the FORK to continue.");
            }
            else // invalid option
            {
                value = 2;
                Console.WriteLine("You got lost. Head back to the FORK to reset.");
            }
        }
        if (value == 2)
        {
            string input2 = Console.ReadLine();
            if (input2 == "fork")
            {
                value = 1;
            }
            else // invalid option
            {
                value = 2;
                Console.WriteLine("You got lost. Head back to the FORK to reset.");
            }
        }
    }
}
