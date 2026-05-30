using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class InsertionSort : Sort
    {
        public InsertionSort(Action<int[]> display) : base(display)
        {
        }

        public override async Task<int[]> sort(int[] arr, CancellationToken token)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                
                int current = arr[i];
                int j = i - 1;
                for (; j >= 0 && current < arr[j]; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = current;

                await Task.Delay(800);
                token.ThrowIfCancellationRequested();
                this.displayFunc(arr);
            }
            return arr;
        }

    }
}
