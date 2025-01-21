using System;
using System.Diagnostics;

namespace Journey_Discount_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double discount = 0;
            bool reply = true;
            double fare = 0, price = 0, payable = 0;

            try
            {
                Console.WriteLine("\t\t\tDiscounted Ride");
                
                //Input: Customer Type
                    Console.WriteLine("Customer Type:");
                    Console.WriteLine("Enter S for Student, E for Employee, and O for Other:");
                    char type = char.Parse(Console.ReadLine());

                    // Type: Student
                    if (type == 's' || type == 'S')
                    {
                        Console.WriteLine("Are you enrolled at BUKC? (yes/no)");
                        string stuTypeInput = Console.ReadLine().ToLower();

                        if (stuTypeInput == "yes")
                        {
                            Console.WriteLine("Are you enrolled in a 4-year degree program? (yes/no)");
                            string stuType2Input = Console.ReadLine().ToLower();

                            if (stuType2Input == "yes")
                            {
                                discount = 20 / 100.0; // 20% discount
                            }
                            else
                            {
                                discount = 15 / 100.0; // 15% discount
                            }
                        }
                        else
                        {
                            discount = 0; // No discount
                        }
                    }
                    // Type: Employee
                    else if (type == 'e' || type == 'E')
                    {
                        Console.WriteLine("Is your grade '8' or higher? (yes/no)");
                        string empTypeInput = Console.ReadLine().ToLower();

                        if (empTypeInput == "yes")
                            discount = 25 / 100.0; // 25% discount
                        else
                            discount = 0; // No discount

                    }
                    // Type: Other
                    else if (type == 'o' || type == 'O')
                    {
                        discount = 0; // No discount
                    }
                    // Invalid Input
                    else
                    {
                        Console.WriteLine("Invalid Input! Please try again.");
                    }

                // Loop for calculating fare
                while (reply)
                {
                    //Input:Distance
                    Console.WriteLine("Enter total distance (in km):");
                    double distance = Convert.ToDouble(Console.ReadLine());

                    if (distance <= 10)
                    {
                        fare = 5000;
                    }
                    else
                    {
                        fare = 7500;
                    }

                    // Proces: Discount Calculation
                    price = fare * discount;
                    //Process: payable Amount Calculation
                    payable = fare - price;

                    //Output: Display relevant info
                    Console.WriteLine($"Fare for your journey: PKR {fare}");
                    Console.WriteLine($"Discount applied: {discount * 100}%");
                    Console.WriteLine($"Payable amount: PKR {payable}");

                    // Input: Asking for another journey
                    Console.WriteLine("Do you want to calculate fare for another journey? (yes/no)");
                    string replyInput = Console.ReadLine().ToLower();

                    reply = replyInput == "yes";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
