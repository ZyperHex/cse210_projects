using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? >>> ");
        string userPercentage = Console.ReadLine();
        int percentage = int.Parse(userPercentage);

        if (percentage >= 90)
        {
            if (percentage >= 94)
            {
                Console.WriteLine("Your grade is A");
            }
            else
            {
                Console.WriteLine("Your grade is A-");
            }
        }
        else if (percentage >= 80)
        {
            if (percentage >= 87)
            {
                Console.WriteLine("Your grade is B+");
            }
            else if (percentage >= 83)
            {
                Console.WriteLine("Your grade is B");
            }
            else
            {
                Console.WriteLine("Your grade is B-");
            }
        }
        else if (percentage >= 70)
        {
            if (percentage >= 77)
            {
                Console.WriteLine("Your grade is C+");
            }
            else if (percentage >= 73)
            {
                Console.WriteLine("Your grade is C");
            }
            else
            {
                Console.WriteLine("Your grade is C-");
            }
        }
        else if (percentage >= 60)
        {
            if (percentage >= 67)
            {
                Console.WriteLine("Your grade is D+");
            }
            else if (percentage >= 63)
            {
                Console.WriteLine("Your grade is D");
            }
            else
            {
                Console.WriteLine("Your grade is D-");
            }
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }
    }
}