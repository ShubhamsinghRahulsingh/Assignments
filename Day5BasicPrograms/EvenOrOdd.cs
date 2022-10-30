using System;
namespace Day5BasicPrograms
{
    public class EvenOrOdd
    {
        public void Check()
        {
            Console.WriteLine("Enter the number you want to check");
            int check= Convert.ToInt32(Console.ReadLine());
            if(check%2==0)
                Console.WriteLine("{0} is an even number",check);
            else
                Console.WriteLine("{0} is an odd number", check);
        }
    }
}
