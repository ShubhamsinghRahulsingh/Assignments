using System;
namespace Day5BasicPrograms
{
    public class FlipCoin
    {
        
        int count_Head = 0, count_Tail = 0;
        public void Flip()
        {

            Console.WriteLine("Enter the number of times you want to flip Coin");
            int num = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < num; i++)
            {
                double check = random.NextDouble();
                if (check > 0.5)
                    count_Head++;
                else
                    count_Tail++;
            }
            Console.WriteLine("Head comes {0} times ", count_Head);
            Console.WriteLine("Tail comes {0} times ", count_Tail);
            float headPercentage = ((float)count_Head / (float)num) * 100;
            Console.WriteLine("Head percentage is {0} ", headPercentage);
            float tailPercentage = ((float)count_Tail / (float)num) * 100;
            Console.WriteLine("Tail percentage is {0} ", tailPercentage);

        }
    }
}

    

