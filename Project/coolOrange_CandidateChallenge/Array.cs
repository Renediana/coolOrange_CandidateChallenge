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
            return new List<int>() 
            { 
                array[position1], 
                array[position2] }
            .Max();
        }

        public static int FindMinPosition(int[] array, int position1, int position2)
        {
            return array
                .ToList()
                .IndexOf(new List<int>()
                {
                    array[position1],
                    array[position2]
                }
                .Min());
        }

        public static void Swap(int[] array, int position1, int position2)
        {
            int temp = array[position1];
            array[position1] = array[position2];
            array[position2] = temp;
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
            for ( int i = 0; i<2; i++ )
            {
                for (int j = 0; j<array.Length; j++)
                {
                    array2D[i, j] += array[j];
                }
            }
            return array2D;
        }

    }
}
