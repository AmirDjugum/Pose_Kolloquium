/*--------------------------------------------------------------
*				HTBLA-Leonding / Class: 1xHIF
*--------------------------------------------------------------
*              Musterlösung-HA
*--------------------------------------------------------------
* Description: (Array-)Distinct with UnitTests
*--------------------------------------------------------------
*/

namespace Distinct
{
    public static class DistinctTools
    {
        public static bool IsDistinct(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static int[] Distinct(int[] ar)
        {
            int[] result = new int[ar.Length];
            int resultLength = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (!Contains(result, ar[i], 0, resultLength))
                {
                    result[resultLength++] = ar[i];
                }
            }
            return Copy(result, resultLength);
        }

        public static int[] Duplicate(int[] ar)
        {
            int[] result = new int[ar.Length];
            int resultLength = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (Contains(ar, ar[i], i + 1, ar.Length) && !Contains(result, ar[i], 0, resultLength))
                {
                    result[resultLength++] = ar[i];
                }
            }
            return Copy(result, resultLength);
        }

        private static bool Contains(int[] ar, int value, int from, int to)
        {
            for (int i = from; i < to; i++)
            {
                if (ar[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        private static int[] Copy(int[] ar, int length)
        {
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = ar[i];
            }
            return result;
        }

    }

}

    
