using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace ComputationalThinkingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("COMPUTATIONAL THINKING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Are These Integers Equal?");
                Console.WriteLine("2. Even or Odd?");
                Console.WriteLine("3. Vowel or Consonant?");
                Console.WriteLine("4. Find the Largest Number");
                Console.WriteLine("5. Divisible by 3");
                Console.WriteLine("6. Restaurant Bill");
                Console.WriteLine("7. Age Category");
                Console.WriteLine("8. Words to Digits");
                Console.WriteLine("9. Which Name is Longer?");
                Console.WriteLine("10. Are these Numbers the Same?");
                Console.WriteLine("11. Name and Place of Birth");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        AreTheseIntegersEqual();
                        break;
                    case "2":
                        EvenOrOdd();
                        break;
                    case "3":
                        VowelOrConsonant();
                        break;
                    case "4":
                        FindLargestNumber();
                        break;
                    case "5":
                        DivisibleBy3();
                        break;
                    case "6":
                        RestaurantBill();
                        break;
                    case "7":
                        AgeCategory();
                        break;
                    case "8":
                        WordsToDigits();
                        break;
                    case "9":
                        WhichNameIsLonger();
                        break;
                    case "10":
                        AreNamesSame();
                        break;
                    case "11":
                        NameAndBirthplace();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void AreTheseIntegersEqual()
        {
            // Write a console application to ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here
            Console.WriteLine("Please enter an integer");
            int integer1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another integer");
            int integer2 = Convert.ToInt32(Console.ReadLine());

            if (integer1 == integer2)
            {
                Console.WriteLine("Integer1 and integer2 are equal!");
            }
            else
            {
                Console.WriteLine("Integer1 and Integer2 do not match!");
            }
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();

        }

        static void EvenOrOdd()
        {
            // Write a console application that asks the user for a number.
            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");




            // Tell the user if that number is even or odd.


            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here

            Console.WriteLine("Please enter a number");


            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("This number is even");
            }
            else
            {
                Console.WriteLine("This number is odd");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void VowelOrConsonant()
        {
            // Write a console application to check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here
            Console.WriteLine("Please enter a Vowel or Consonant");
            string vowel = Console.ReadLine();

                    

            switch (vowel)
            {
                case "a":
                    Console.WriteLine("A is a vowel");
                    break;
                case "e":
                    Console.WriteLine("E is a vowel");
                    break;
                case "i":
                    Console.WriteLine("I is a vowel");
                    break;
                case "o":
                    Console.WriteLine("O is a vowel");
                    break;
                case "u":
                    Console.WriteLine("U is a vowel");
                    break;
                default:
                    Console.WriteLine("This is a consonant");
                    break;
                
            }
                
            

            
            
             

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void FindLargestNumber()
        {
            // Write a console application that prompts the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here
            Console.WriteLine("Please input a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input another number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Your 1st num is bigger");

            }
            else if (num1 == num2)
            {
                Console.WriteLine("These numbers are equal");

            }
            else
            {
                Console.WriteLine("Your 2nd num is bigger");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here
            Console.WriteLine("Please enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 3 == 0)
            {
                Console.WriteLine("This number is divisible by 3");

            }

            else
            {
                Console.WriteLine("This number is not divisible by 3");

            }



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void RestaurantBill()
        {
            // At a restaurant, Mike and his three friends decided to divide the bill evenly.
            // If each person paid $13 then what was the total bill?

            // Returning to the above problem, replace hard-coded values of 4(number of diners)
            // and 13(cost per diner) with values provided by the user.

            // How nice!The restaurant is having Customer Appreciation Week.
            // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            // Otherwise, they’ll receive a 5 % discount.

            Console.Clear();
            Console.WriteLine("RESTAURANT BILL\n");

            // Enter your solution here
             
            
            Console.WriteLine("Please enter the total bill");
            
            int totalBill = Convert.ToInt32(Console.ReadLine());
               
            if (totalBill >= 52)
            {
                Console.WriteLine("You get a 10 % discount");
                
            }
            else if (totalBill <= 52)
            {
                Console.WriteLine("You get a 5% discount");
            }

            Console.WriteLine("Press enter to return to the main menu");
            Console.ReadLine();
        }
        static void AgeCategory()
        {
            // You're responsible for providing a demographic report for your local school district based on age.
            // To do this, you're going to determine which 'category' each person fits into based on their age.
            // The person's age will determine which category they should be in:

            // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
            // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
            // From 12 to 14: 'Middle School'
            // From 15 to 18: 'High School'
            // From 19 to 22: 'College'
            // From 23 to 65: 'Working for the Man'
            // From 66 to 100: 'The Golden Years'
            // If the age of the person is less than 0 or more than 100 - it might be an alien
            // print: "This program is for humans".

            Console.Clear();
            Console.WriteLine("AGE CATEGORY\n");

            // Enter your solution here
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 2)
            {
                Console.WriteLine("Still in Mama's Arms");
            }
            else if (age <= 4)
            {
                Console.WriteLine("Preschool Maniac");
            }

            else if (age <= 11)
            {
                Console.WriteLine("Elementary School");
            }


            else if (age <= 14)
            {
                Console.WriteLine("Middle School");
            }

            else if (age <= 18)
            {
                Console.WriteLine("High School");
            }

            else if (age <= 22)
            {
                Console.WriteLine("College");
            }

            else if (age <= 65)
            {
                Console.WriteLine("Working For The Man");
            }

            else if (age <= 100)
            {
                Console.WriteLine("The Golden Years");
            }

            else if (age < 0)
            {
                Console.WriteLine("This program is for Humans");
            }
            else if (age > 100)
            {
                Console.WriteLine("This program is for Humans");
}
                 Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            
        }

            static void WordsToDigits()
            {
                // Having a string representation of a number, you need to print the digit form of the number.
                // Ask the user to enter a string representation of a number from zero to ten.
                // Using switch case, print the digit (0-10) representation of the number.

                Console.Clear();
                Console.WriteLine("WORDS TO DIGITS\n");

                // Enter your solution here
                Console.WriteLine("Pick a number from zero to ten");
                string digit = Console.ReadLine();
                switch (digit)
                {
                    case "zero":
                        Console.WriteLine("0");
                        break;
                    case "one":
                        Console.WriteLine("1");
                        break;
                    case "two":
                        Console.WriteLine("2");
                        break;
                    case "three":
                        Console.WriteLine("3");
                        break;
                    case "four":
                        Console.WriteLine("4");
                        break;
                    case "five":
                        Console.WriteLine("5");
                        break;
                    case "six":
                        Console.WriteLine("6");
                        break;
                    case "seven":
                        Console.WriteLine("7");
                        break;
                    case "eight":
                        Console.WriteLine("8");
                        break;
                    case "nine":
                        Console.WriteLine("9");
                        break;
                    case "ten":
                        Console.WriteLine("10");
                        break;

                }

                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void WhichNameIsLonger()
            {
                // Ask the user for their first and last name.

                // Print the user's full name.
                // If the first name is longer than the last name, print "First is longer."
                // If the first name and last name are the same length, print "Same-sies!"
                // Otherwise, print "Last must be longer!"

                Console.Clear();
                Console.WriteLine("WHICH NAME IS LONGER?\n");

                // Enter your solution here
                Console.WriteLine("Please enter your first name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please enter your last name");
                string lastName = Console.ReadLine();
            if (firstName.Length == lastName.Length)
            {
                Console.WriteLine("Same-sies!");

            }
            else if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("First is longer");

            }
            else if (firstName.Length < lastName.Length)
            {
                Console.WriteLine("Last must be longer");
            }

                    

                    Console.Write("Press enter to return to the Main Menu");
                    Console.ReadLine();
                }

                static void AreNamesSame()
                {
                    // Ask the user for 2 names.

                    // If the two names are the same, print "The names are the same."
                    // If they're not the same, print "The names are different."

                    Console.Clear();
                    Console.WriteLine("ARE THESE NAMES THE SAME?\n");

                    // Enter your solution here
                    Console.WriteLine("Please enter a name");
                    string userName1 = (Console.ReadLine());
                    Console.WriteLine("Please enter another name");
                    string userName2 = (Console.ReadLine());

                    if (userName1 == userName2)
                    {
                        Console.WriteLine("These names are the same");
                    }
                    else
                    {
                        Console.WriteLine("These names are different");
                    }








                    Console.Write("Press enter to return to the Main Menu");
                    Console.ReadLine();
                }

                static void NameAndBirthplace()
                {
                    // Ask the user for their first name and where they were born.
                    // Print a sentence to the console that repeats this information.

                    Console.Clear();
                    Console.WriteLine("NAME AND PLACE OF BIRTH\n");

                    // Enter your solution here
                    Console.WriteLine("Please enter your name");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Please enter your place of birth");
                    string placeOfBirth = Console.ReadLine();
                    Console.WriteLine("Your name is " + userName + " and " + "your place of birth is " + placeOfBirth);


                    Console.Write("Press enter to return to the Main Menu");
                    Console.ReadLine();
                }

            }

        }





