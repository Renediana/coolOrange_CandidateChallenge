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

    }
}
