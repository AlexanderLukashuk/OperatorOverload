using System;

namespace OperatorOverloadPractickalWork
{
    public class ArrayClass
    {
        public int size = 10;
        public int[] array;
        public ArrayClass()
        {
            for (int i = 0; i < size; i++)
            {
                var rnd = new Random();
                array[i] = rnd.Next(100);
            }
        }
        public static bool operator <(ArrayClass firstArray, ArrayClass secondArray)
        {
            bool result;
            int firstAmountElements = 0;
            int secondAmountElements = 0;
            for (int i = 0; i < firstArray.size; i++)
            {
                firstAmountElements += firstArray.array[i];
                secondAmountElements += secondArray.array[i];
            }

            if (firstAmountElements < secondAmountElements)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public static bool operator >(ArrayClass firstArray, ArrayClass secondArray)
        {
            bool result;
            int firstAmountElements = 0;
            int secondAmountElements = 0;
            for (int i = 0; i < firstArray.size; i++)
            {
                firstAmountElements += firstArray.array[i];
                secondAmountElements += secondArray.array[i];
            }

            if (firstAmountElements > secondAmountElements)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}