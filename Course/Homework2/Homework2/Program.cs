using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        //�q�T�ӼƸ̭�,�D�X�̤j��
        private static int a = 88;
        private static int b = 52;
        private static int c = 108;
        private static int x = 0;//�D�X�Ӫ���,���w��x
        private static int totalNums = 3;
        public static void Main(string[] args)
        {
            //�}�l�g�@�~
            List<int> num = new List<int>();
            num.Add(a);
            num.Add(b);
            num.Add(c);

            int[] numbers = new int[totalNums];
            numbers[0] = a;
            numbers[1] = b;
            numbers[2] = c;



            //�@�~�g���F

            Console.WriteLine("�Q��List��X,�̤j���ƬO: " + listMaximum(x, num));
            Console.WriteLine("�Q��Array��X,�̤j���ƬO: " + arrayMaximum(x, numbers));
            Console.ReadKey();

        }
        public static int listMaximum(int x, List<int> num)
        {
            for (int i = 0; i < num.Count - 1; i++)
            {
                for (int j = 0; j < num.Count - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        x = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = x;
                    }
                    else
                    {
                        x = num[j + 1];
                    }
                }
            }
            return x;
        }
        public static int arrayMaximum(int x, int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        x = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = x;
                    }
                    else
                    {
                        x = numbers[j + 1];
                    }
                }
            }
            return x;
        }
    }
}
