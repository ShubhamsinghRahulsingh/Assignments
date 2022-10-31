using System;
namespace Day5BasicPrograms
{
    public class PrimeFactors
    { 
        public void Factor()
        {
            int count=0;
            Console.WriteLine("Enter the number for which you want to find prime factors");
            int pNum = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i <= pNum; i++)
            {
                if(pNum%i== 0)
                {
                    for(int j = 1; j <= i; j++)
                    {
                        if(i%j== 0)
                        {
                           count++;
                        }
                    }
                    if(count==2)
                    {
                        Console.WriteLine("Prime factor of number {0} is: {1}",pNum,i);
                    }
                    count = 0;
                }
            }
        }
    }
}
