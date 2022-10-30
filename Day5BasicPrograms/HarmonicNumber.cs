using System;
namespace Day5BasicPrograms
{
    public class HarmonicNumber
    {
        float sum = 0;
        public void Harmonic()
        {
            Console.WriteLine("Enter the number upto which you want harmonic series");
            int num1=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=num1;i++)
            {
                this.sum += (float) 1 / i ; 
            }
            Console.WriteLine("Sum of Nth Harmonic series is {0}",sum);
        }
    }
}
