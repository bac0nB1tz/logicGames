using System;

namespace HelloWorld
{
    class Program
    {
        static int findMissingNumber(int[] array){
            int actualSum = 0;
            foreach(var arr in array){
                actualSum += arr;
            }

            Console.WriteLine("ActualSum:" + actualSum);

            int n = array.Length+1;
            Console.WriteLine("n:" + n);
            
            int sumOfN = (n * (n + 1)) / 2;
            Console.WriteLine("sumOfN:" + sumOfN);


            return sumOfN - actualSum;
        }

        static void Main(string[] args)
        {
            int[] array = {3,7,1,2,8,4,5};
            // x = 6
            Console.WriteLine(findMissingNumber(array));
        }
    }
}