using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public static class Sort
    {
        public static void Bubble(int[] arr)
        {
<<<<<<< HEAD
            for (var i = 0; i < arr.Length - 1; i++)
=======
            for(var i = 0; i < arr.Length - 1; i++)
>>>>>>> 0a600bfd29ef7acb265ce19ac8d211ece85710c6
            {
                for (var k = 0; k < arr.Length - 1 - i; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        var temp = arr[k];
                        arr[k] = arr[k + 1];
                        arr[k + 1] = temp;
                    }
                }
            }
        }

        public static void Selection(int[] arr)
        {
            int smallest;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                smallest = i;
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[k] < arr[smallest])
                    {
                        smallest = k;
                    }
                }
                int temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
        }
        public static void Insertion(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int val = arr[i];
                //int flag = 0;
                for (int j = i - 1; j >= 0 && /*flag != 1*/;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    //else flag = 1;
                }
            }
        }
        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1) return arr;
            decimal midpoint = arr.Length / 2;
            var mid = Convert.ToInt32(Math.Ceiling(midpoint));

            var bot = arr.Take(mid).ToArray();
            var top = arr.Skip(mid).ToArray();

            var bottomOut = MergeSort(bot);
            var topOut = MergeSort(top);

            var combine = Combine(bottomOut, topOut);

            return combine;
        }
        private static int[] Combine(int[] bottom, int[] top)
        {
            var i = 0; //bottom
            var j = 0; //top
            var k = 0;
            var arr = new int[bottom.Length + top.Length];

            while (i < bottom.Length && j < top.Length)
            {
                if(bottom[i] < top[j])
                {
                    arr[k] = bottom[i];
                    i++;
                }    
                else {
                    arr[k] = top[j];
                    j++;
                }
                k++;
            }  
            while (i < bottom.Length)
            {
                arr[k] = bottom[i];
                i++;
                k++;
            }
            while (j < top.Length)
            {
                arr[k] = top[j];
                j++;
                k++;
            }
            return arr;
        }
    }
}
