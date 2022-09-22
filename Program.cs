// See https://aka.ms/new-console-template for more information
using System;



class Test
{
    static void Main(string[] args)
    {
        int Addition(int num1, int num2)
        {
            return num1 + num2;
        }





        int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }





        int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }





        int Divition(int num1, int num2)
        {
            return num1 / num2;
        }



        do
        {



            Console.Clear();

            int num1 = 0;
            int num2 = 0;
            int result = 0;
            Console.Write("Enter the 1st number: ");
            num1 = int.Parse(Console.ReadLine());



            Console.Write("Enter the 2nd number: ");
            num2 = int.Parse(Console.ReadLine());





            Console.WriteLine("Press the number of the matmatical operation that you want to do:  \n1. For addittion \n2. For subtraction \n3. For multiplication \n4. For division");
            int ch = int.Parse(Console.ReadLine());




            switch (ch)
            {
                case 1:
                    result = Addition(num1, num2);
                    Console.WriteLine(result);
                    break;
                case 2:
                    result = Subtraction(num1, num2);
                    Console.WriteLine(result);
                    break;
                case 3:
                    result = Multiplication(num1, num2);
                    Console.WriteLine(result);
                    break;
                case 4:



                    if (num2 != 0)
                    {
                        result = Divition(num1, num2);
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("This number cant be divided");
                    }


                    break;
                default:
                    Console.WriteLine("The number you entered is incorrect. Please enter a correct number:");
                    break;
            }
            Console.WriteLine("Do you want to continue ! Press Y = yes  N = NO: ");




        }
        while (Console.ReadLine().ToUpper() == "Y");
        Console.WriteLine("Bye Bye!");
        Console.ReadKey();
    }
}