using System;
using System.Collections.Generic;
using System.Text;

namespace _27._10._26_homework_
{
    internal class Array: ICalc,IOutput2
    {
        int[] number;

        public Array(int[] number)
        {
            this.number = number;
        }

        public int Less(int ValueToCompare)
        {
            int count = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < ValueToCompare)
                {
                    count ++;
                }
            }
            return count;
        }

        public int Greater(int ValueToCompare)
        {
            int count = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > ValueToCompare)
                {
                    count++;
                }
            }
            return count;
        }



        ///////////TASK2///////////
        public void ShowEven()
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    Console.Write(number[i] + " ");
                }
            }
            Console.WriteLine();
        }
        public void ShowOdd()
        {
            for(int i  = 0; i < number.Length;i++)
            {
                if(number[i] % 2 != 0)
                {
                    Console.Write(number[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
