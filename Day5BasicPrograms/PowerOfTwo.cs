using System;
namespace Day5BasicPrograms
{
    public class PowerOfTwo
    {
       public void Table ()
        {
            Console.WriteLine("Enter number between 0 to 30 upto which you want table");
            int number=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=number;i++)
            {
                int multiply = 2 * i;
                Console.WriteLine("2*{0}= {1} ", i,multiply);

            }
        }

    }
}
