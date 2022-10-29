using Day5BasicPrograms;
using System;
namespace Day5BasicProgrmas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.FlipCoin" +" \n" + "2.LeapYear");
            Console.WriteLine("Enter the option from the above that you want to go for");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin percentage = new FlipCoin();
                    percentage.Flip();
                    break;
                case 2:
                    LeapYear leap=new LeapYear();
                    leap.Leap();
                    break;
        }
        }    
    }
}