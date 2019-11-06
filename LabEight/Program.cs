using System;

namespace LabEight
{
    class Program
    {
        static void Main(string[] args)
        {
            //use parrallel arrays
            string[] names = { "Jacob", "Drew", "Peter" };
            string[] foods = { "Cookies", "Ice Cream", "Thai Food" };
            string[] hometown = { "Merrillville", "Detroit", "Michigan" };
            string repeat = "y";

            while (repeat == "y")
            {
                //welcome user and ask which student they want to learn about

                Console.WriteLine("Welcome to our C# class. Which student would you like to learn about? enter a number (1-3)");
                //show list of names

                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {names[i]}");
                }

                bool again = true;
                bool again2 = true;
                string learnMore = "";

                try
                {
                    int studentNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Student {studentNumber} is {names[studentNumber - 1]}. What would you like to learn about {names[studentNumber - 1]}? (favorite food or hometown)");
                    string newInfo = Console.ReadLine();

                    while (again == true)
                    {
                        if (newInfo == "favorite food")
                        {
                            Console.WriteLine($"{names[studentNumber - 1]}'s favorite food is {foods[studentNumber - 1]}. Would you like to learn more? (y/n)");
                            again = false;
                            learnMore = Console.ReadLine().ToLower();
                        }
                        else if (newInfo == "hometown")
                        {
                            Console.WriteLine($"{names[studentNumber - 1]}'s hometown is {hometown[studentNumber - 1]}. Would you like to learn more? (y/n)");
                            again = false;
                            learnMore = Console.ReadLine().ToLower();
                        }
                        else
                        {
                            Console.WriteLine("That data does not exist. Please enter favorite food or hometown");
                            newInfo = Console.ReadLine();
                        }
                    }
                    while (again2 == true)
                    {
                        if (learnMore == "y" && newInfo == "favorite food")
                        {
                            Console.WriteLine($"{names[studentNumber - 1]}'s hometown is {hometown[studentNumber - 1]}. Would you like to learn about a different student? (y/n)");
                            again2 = false;
                            repeat = Console.ReadLine().ToLower();
                        }
                        else if (learnMore == "y" && newInfo == "hometown")
                        {
                            Console.WriteLine($"{names[studentNumber - 1]}'s favorite food is {foods[studentNumber - 1]}. Would you like to learn about a different student? (y/n)");
                            again2 = false;
                            repeat = Console.ReadLine().ToLower();
                        }
                        else if (learnMore == "n")
                        {
                            Console.WriteLine("Goodbye");
                            again2 = false;
                        }
                        else
                        {
                            Console.WriteLine("Input not valid, please enter y or n");
                            learnMore = Console.ReadLine().ToLower();
                        }

                        if (repeat == "n" )
                        {
                            Console.WriteLine("Goodbye");
                        }
                        else if (repeat != "n" && repeat != "y")
                        {
                            Console.WriteLine("Input not valid, please enter y or n");
                            repeat = Console.ReadLine().ToLower();
                        }
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Incorrect format. Please try again");
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Index out of range. Please try again");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
