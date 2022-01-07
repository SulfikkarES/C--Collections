#region Copyright EazyLearn
//
// All rights are reserved. Reproduction or transmission in whole or in part, 
// in any form or by any means, electronic, mechanical or otherwise, is
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : C#Collections.cs
// Purpose         : To practice C# Collections 
// Creation Date   : 20-09-2021
// Author          : Sulfikkar E S
//
// Change History  :
// Changed by      :              
// Date            : 
// Purpose         :
//
#endregion Copyright 

#region Included namespaces
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion Included namsppaces

namespace EazyLearn.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n\t *** Menu ***\n");
                Console.WriteLine("1 :Array List" +
                    "\n 2 : Hash Table " +
                    "\n 3 : Frequency Of Words" +
                    "\n 4 : Linked List " +
                    "\n 5 : Queue Creation " +
                    "\n 6 : Prime Numbers over the Range 2 to n" +
                    "\n 7 :Postfix Expression" +
                    "\n 8 :List Of Programming Languages" +
                    "\n 9  : Dictionary with names of the country" +
                    "\n 10 :Customer details" +
                    "\n 11 :Data Structure of 5 Students");
                //blank line to separate the input statements
                Console.WriteLine("\nPlease Select Any Option : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1 :Array List\n\t*******\n");
                        CreateAndDisplayArrayList();
                        break;
                    case 2:
                        Console.WriteLine("2 : Calculator\n\n\t*****\n");
                        CreateHashTable();
                        break;
                    case 3:
                        Console.WriteLine("3 : Frequency Of Words\n\t*****\n");
                        PrintFrequencyOfWords();
                        break;

                    case 4:
                        Console.WriteLine("4: Linked List \n\t******\n");
                        CreateLinkedList();
                        break;
                    case 5:
                        Console.WriteLine("5 : Display values in the queue\n\t******\n");
                        CreateQueue();
                        break;
                    case 6:
                        Console.WriteLine("6 : Calculate Prime Numbers over the Range 2 to n\n\t*****\n");
                        CalculatePrimeNumbersBetween2AndRange();
                        break;
                    case 7:
                        Console.WriteLine("7 :Postfix Expression\n\t*****\n");
                        DeterminePostfixExpression();
                        break;
                    case 8:
                        Console.WriteLine("8 :List Of Programming Languages\n\t*****\n");
                        CreateListOfProgrammingLanguages();
                        break;
                    case 9:
                        Console.WriteLine("9 : Dictionary with names of the country\n\t******\n");
                        CreateDitionary();
                        break;
                    case 10:
                        Console.WriteLine("10 :Customer details\n\t*****\n");
                        CreateCustomerClass();
                        break;
                    case 11:
                        Console.WriteLine("11 : Data Structure of 5 Students\n\t*****\n");
                        CreateDataStructure();
                        break;
                    case 0: break;
                    default:
                        Console.WriteLine(" Invalid Option Is Selected "); break;
                }
            } while (choice != 0);
            Console.Read();
        } //main end here

        static void CreateAndDisplayArrayList()
        {
            //class name cannot be verb
            DisplayArrayList obj1 = new DisplayArrayList();
            obj1.Display();
            Console.ReadLine();
        }// End of CreateAndDisplayArrayList()

        static void CreateHashTable()
        {
            MyHashTable obj2 = new MyHashTable();
            obj2.Display();
            Console.ReadLine();
        }// End Of CreateHashTable()

        static void CreateLinkedList()
        {
            //class name cannot be verb
            CreateLinkedList obj2 = new CreateLinkedList();
            obj2.Display();
            Console.ReadLine();
            Console.ReadLine();
        }// End of CreateLinkedList()

        static void CreateQueue()
        {
            //class name cannot be verb
            CreateAndDisplayQueue obj3 = new CreateAndDisplayQueue();
            obj3.Display();
            Console.ReadLine();
        }//End of CreateQueue()

        static void CreateListOfProgrammingLanguages()
        {
            ListOfProgrammingLanguages obj4 = new ListOfProgrammingLanguages();
            obj4.Display();
            Console.ReadLine();
        }//End of CreateListOfProgrammingLanguages()

        static void CreateDitionary()
        {
            //Spelling of dictionary
            DisplayDitionary obj5 = new DisplayDitionary();
            obj5.display();
            Console.ReadLine();
        }//End of CreateDitionary()
        static void CreateCustomerClass()
        {
            Customer obj6 = new Customer(1, "Akhil");
            Customer obj7 = new Customer(2, "Amal");
            Customer obj8 = new Customer(3, "Anandhu");

            Dictionary<int, Customer> customerdictionary = new Dictionary<int, Customer>();
            customerdictionary.Add(1, obj6);
            customerdictionary.Add(2, obj7);
            customerdictionary.Add(3, obj8);
            Console.WriteLine("key\tCustomer id\tCustomer name");

            foreach (KeyValuePair<int, Customer> element in customerdictionary)
            {
                Customer val = element.Value;
                Console.WriteLine($"key: {element.Key} \tcustomer id: {Convert.ToString(val.Customerid)}\t Customer Name {val.Customername} ");
            }
            Console.ReadLine();
        }//End CreateCustomerClass()

        static void CreateDataStructure()
        {
            int i;

            StringCollection studentNames = new StringCollection();

            Console.WriteLine("Enter 5 student names");
            for (i = 0; i < 5; i++)
            {
                studentNames.Add(Console.ReadLine());
            }
            Console.WriteLine("student names");

            foreach (string name in studentNames)
            {
                Console.Write($"{name}  \t");
            }
        } //End of CreateDataStructure()

        static void CalculatePrimeNumbersBetween2AndRange()
        {
            int range, counter, i;

            Console.WriteLine("Enter the range for prime numbers to display");
            range = Convert.ToInt32(Console.ReadLine());

            BitArray primeNumbers = new BitArray(range);

            //Function to check number is prime or not
            bool PrimeOrNot(int number)
            {
                int j;

                int factors = 0;

                for (j = 1; j <= number; j++)
                {
                    if (number % j == 0)
                    {
                        factors++;
                    }
                }
                if (factors == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            counter = 0;

            for (i = 2; i <= range; i++)
            {
                primeNumbers[counter] = PrimeOrNot(i);
                counter++;
            }
            Console.WriteLine($"Prime numbers between 2 and {range} are shown below");

            for (i = 2; i <= range; i++)
            {
                if (primeNumbers[i - 2] == true)
                {
                    Console.Write($"{i}  \t");
                }
            }
        }//End of CalculatePrimeNumbersBetween2AndRange()

        static void DeterminePostfixExpression()
        {
            //variable declaration order
            Stack valueStack = new Stack();
            string expression;
            int i, firstOperand, secondOperand, result;
            char operatorSymbol;
            string[] elements;

            Console.WriteLine("Enter expression");
            expression = Console.ReadLine();

            expression = expression.Trim();
            elements = expression.Split(' ');

            //Function that returns the solution of an expression given two operands and an operator
            int EvaluateExpression(int firstNumber, int secondNumber, char choice)
            {
                int resultOfExpression = 0;

                switch (choice)
                {
                    case '+':
                        resultOfExpression = firstNumber + secondNumber;
                        break;
                    case '-':
                        resultOfExpression = firstNumber - secondNumber;
                        break;
                    case '*':
                        resultOfExpression = firstNumber * secondNumber;
                        break;
                    case '/':
                        resultOfExpression = firstNumber / secondNumber;
                        break;
                    case '%':
                        resultOfExpression = firstNumber % secondNumber;
                        break;
                    case '^':
                        resultOfExpression = (int)Math.Pow(firstNumber, secondNumber);
                        break;
                }
                return resultOfExpression;
            }

            for (i = 0; i < elements.Length; i++)
            {
                valueStack.Push(elements[i]); //Pushing values into the stack
                operatorSymbol = Convert.ToChar(valueStack.Peek()); //chec last pushed value is operator symbol
                if (operatorSymbol == '+' || operatorSymbol == '-' || operatorSymbol == '*' || +
                    operatorSymbol == '/' || operatorSymbol == '%' || operatorSymbol == '^')
                {
                    operatorSymbol = Convert.ToChar(valueStack.Pop());
                    secondOperand = Convert.ToInt32(valueStack.Pop());
                    firstOperand = Convert.ToInt32(valueStack.Pop()); //getting the last three values inserted into the stack and doing the operation on them
                    result = EvaluateExpression(firstOperand, secondOperand, operatorSymbol);
                    valueStack.Push(result); //pushing the result back into the stack for further operations
                }
            }
            Console.WriteLine(Convert.ToInt32(valueStack.Pop()));
        }//End of Postfix Expression

        static void PrintFrequencyOfWords()
        {
            string sentence;
            char[] characterArray;
            int i, j;
            Hashtable wordFrequency = new Hashtable();

            int counter = 0;

            Console.WriteLine("Enter sentence");
            sentence = Console.ReadLine();
            //Removing all spaces and punctuation marks and keeping only spaces and letters in the sentence
            characterArray = sentence.ToCharArray();
            sentence = "";

            foreach (char character in characterArray)
            {
                if (char.IsLetter(character) || char.IsWhiteSpace(character) || character == '-')
                {
                    sentence += character;
                }
            }
            sentence = sentence.Trim();

            string[] words;
            words = sentence.Split(' ');

            for (i = 0; i < words.Length; i++)
            {
                for (j = 0; j < words.Length; j++)
                {
                    if (words[i].Equals(words[j], StringComparison.OrdinalIgnoreCase))
                    {
                        counter++;
                    }
                }
                if (wordFrequency.ContainsKey(words[i]) == false)
                {
                    wordFrequency[words[i]] = counter;
                }
                counter = 0;
            }
            Console.WriteLine("Word\tFrequency");

            foreach (DictionaryEntry mp in wordFrequency)
            {
                Console.WriteLine($"{mp.Key}  \t  {mp.Value}");
            }
        }// End of PrintFrequencyOfWords()
    }

}
