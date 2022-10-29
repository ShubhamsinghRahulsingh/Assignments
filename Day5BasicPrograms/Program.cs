using Day5BasicPrograms;
using System;
namespace Day5BasicProgrmas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            { 
            Console.WriteLine("1.FlipCoin" +" \n" + "2.LeapYear" + "\n" +"3.PowerOfTwo" + "\n" +"4.EXIT");
            Console.WriteLine("Enter the option from the above that you want to go for");
            int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin percentage = new FlipCoin();
                        percentage.Flip();
                        break;
                    case 2:
                        LeapYear leap = new LeapYear();
                        leap.Leap();
                        break;
                    case 3:
                        PowerOfTwo table = new PowerOfTwo();
                        table.Table();
                        break;
                    case 4:
                        flag= false;
                        break;
                }
        }
        }    
    }
}