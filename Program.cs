using System;

namespace Exercise14
{
    class Program
    {
        /*  Create a console-based application whose Main() method asks the user to input an integer 
            and then calls a method named MultiplicationTable(), which displays the results of 
            multiplying the integer by each of the numbers 2 through 10*/
        static void Main(string[] args)
        {
            Console.WriteLine("Input a integer: ");
            int input1 = Convert.ToInt32(Console.ReadLine());


            for (int i = 2; i < 11; i++)
            {
                int answer = input1 * i;
                Console.WriteLine("{0,2} * {1,2} = {2,2}", i, input1, answer);
            }
        }

    }
}
