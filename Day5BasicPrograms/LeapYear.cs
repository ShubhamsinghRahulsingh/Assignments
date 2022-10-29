using System;
namespace Day5BasicPrograms
{
    public class LeapYear
    {
        public void Leap()
        {
            Console.WriteLine("Enter the Year in four digits to check for leap year");
            int year= Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                Console.WriteLine("{0} is a leap year", year);
            else
                Console.WriteLine("{0} is not a leap year", year);
            
        }
    }
}
