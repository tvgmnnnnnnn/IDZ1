using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz1_opp
{
    internal class iz1
    {
        public static void DoTask()
        {
            Console.Write("Введите кол-во чисел");
            int n = int.Parse(Console.ReadLine());

            float[] A = new float[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите " + (i + 1) + "-е число ");
                A[i] = float.Parse(Console.ReadLine());
            }

            Array.Sort(A);
            float sum = 0;

            for (int i = 0; i < 2; i++)
            {
                sum = sum + A[i];
            }

            Console.WriteLine(sum);
        }
    }
}
