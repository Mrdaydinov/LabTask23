using System.Reflection.Emit;

namespace LabTask23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 2, 8, 7, 5, 6, 3 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            int firstNumsSum = arr[0] + arr[1];
            int lastNumsSum = arr[^1] + arr[^2];


        Label:
            Console.WriteLine("Enter operator");
            var oper = Console.ReadLine();

            if (oper == null)
                goto Label;

            if (oper == "+")
                Console.WriteLine($"{firstNumsSum} + {lastNumsSum} = {firstNumsSum + lastNumsSum}");
            else if (oper == "-")
                Console.WriteLine($"{lastNumsSum} - {firstNumsSum} = {lastNumsSum - firstNumsSum}");
            else if (oper == "*")
                Console.WriteLine($"{firstNumsSum} * {lastNumsSum} = {firstNumsSum * lastNumsSum}");
            else if (oper == "/")
                Console.WriteLine($"{lastNumsSum} / {firstNumsSum} = {lastNumsSum / firstNumsSum}");
            else
            {
                Console.WriteLine("Wrong operator");
                goto Label;
            }
        }
    }
}
