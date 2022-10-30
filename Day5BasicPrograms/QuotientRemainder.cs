using System;
namespace Day5BasicPrograms
{
    public class QuotientRemainder
    {
        public void Operations()
        {
            int dividend = 100, divisor = 5;
            int quotient= dividend/divisor;
            int remainder= dividend%divisor;
            Console.WriteLine("Dividend is: "+ dividend);
            Console.WriteLine("Divisor is: "+ divisor);
            Console.WriteLine("Quotient is: "+ quotient);
            Console.WriteLine("Remainder is: "+ remainder);
        }
    }
}
