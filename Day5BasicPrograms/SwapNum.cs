using System;
namespace Day5BasicPrograms
{
    public class SwapNum
    {
        public void NumSwap()
        {
            int num1 = 500, num2 = 700;
            Console.WriteLine("Before swapping,numbers are: \nNumber1:{0}\nNumber2:{1} ", num1,num2);
            num1 += num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("After swapping,numbers are: \nNumber1:{0}\nNumber2:{1} ", num1, num2);


        }
    }
}
