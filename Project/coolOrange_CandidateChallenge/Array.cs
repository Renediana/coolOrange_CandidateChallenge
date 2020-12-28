using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    public class Array
    {
        public static int FindMaxValue(int[] array, int position1, int position2)
        {
            return array
                    .Skip(position1)
                    .Take(position2-position1)
                    .ToArray()
                    .Max();
        }

        public static int FindMinPosition(int[] array, int position1, int position2)
        {
            return array
                .ToList()
                .IndexOf(array
                        .Skip(position1)
                        .Take(position2 - position1)
                        .ToArray()
                        .Min()
                        );
        }

        public static void Swap(int[] array, int position1, int position2)
        {
            int temp = array[position1];
            array[position1] = array[position2];
            array[position2] = temp;
        }

        public static void ShiftLeftByOne(int[] array, int position1, int position2)
        {
            var new_array = array.Skip(position1).Take(position2-position1).ToArray();
            var shifted_array = new_array.Skip(1).Concat(new int[] { new_array[0] });

            var result = String
                .Join(",", array)
                .Replace(
                String.Join(",", new_array), 
                String.Join(",", shifted_array)
                ).ToArray()
                .Select( num => Convert.ToInt32(num));
        }

        public static int[] CreateRandomArray(int size, int minValue, int maxValue)
        {
            var array = new int[size];
            for ( int i = 0; i<size; i++ )
            {
                array[i] = new Random().Next(minValue, maxValue);
            }
            return array;
        }

        public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
        {
            int[,] array2D = new int[rows, columns];
            for ( int i = 0; i<rows; i++)
            {
                for (int j = 0; j<columns; j++)
                {
                    array2D[i, j] = new Random().Next(minValue, maxValue);
                }
            }
            return array2D;
        }

        public static int[,] CopyArray(int[] array)
        {
            int[,] array2D = new int[2, array.Length];
            for (int j = 0; j<array.Length; j++)
            {
                array2D[0, j] = array[j];
                array2D[1, j] = array[j];
            }
            return array2D;
        }

        public static int FindInSortedArray(int[] array, int number)
        {
            if (array.ToList().Contains(number))
            {
                int min = 0;
                int max = array.Length - 1;

                while (min <= max)
                {
                    int mid = (min + max) / 2;
                    if (number == array[mid])
                    {
                        return ++mid;
                    }
                    else if (number < array[mid])
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
                return -1;
            }
            else
            {
                return -1;
            }
        }
    }
}
