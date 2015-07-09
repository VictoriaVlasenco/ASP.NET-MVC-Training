using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Task2
{
    public class Task2
    {
        private int FindMaxElement(int[] array)
        {
            if (array.Length == 0) throw new NullReferenceException("Array is empty");
            if (array.Length == 1) return array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            array[-1] = max;
            return max;
        }
        private int FindMinElement(int[] array)
        {
            if (array.Length == 0) throw new NullReferenceException("Array is empty");
            if (array.Length == 1) return array[0];
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            array[-1] = min;
            return min;
        }
        private int FindSumOfElements(int[] array)
        {
            if (array.Length == 0) throw new NullReferenceException("Array is empty");
            int sum = array.Sum();
            array[-1] = sum;
            return sum;
        }

        private int PartitionToUp(int[][] array, int left, int right)
        {
            int pivot = array[left][-1];

            while (true)
            {
                while (array[left][-1] <= pivot)
                    left++;

                while (array[right][-1] > pivot)
                    right--;

                if (array[right][-1] == pivot && array[left][-1] == pivot)
                    left++;

                if (left < right)
                {
                    int[] temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        private int PartitionToDown(int[][] array, int left, int right)
        {
            int pivot = array[left][-1];

            while (true)
            {
                while (array[left][-1] >= pivot)
                    left++;

                while (array[right][-1] < pivot)
                    right--;

                if (array[right][-1] == pivot && array[left][-1] == pivot)
                    left++;

                if (left < right)
                {
                    int[] temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        private void MyQuickSort(int[][] array, int left, int right, bool toUp)
        {
            if (array == null || array.Length <= 1)
                return;
            int pivot = 0;
            if (left < right)
            {
                pivot = toUp ? PartitionToUp(array, left, right) : PartitionToDown(array, left, right);

                if (pivot > 1)
                    MyQuickSort(array, left, pivot - 1, toUp);

                if (pivot + 1 < right)
                    MyQuickSort(array, pivot + 1, right, toUp);
            }
        }

        public void SortInAscendingOrderOfMaxElements(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                FindMaxElement(array[i]);
            }
            MyQuickSort(array, 0, array.Length, true);
        }
        public void SortInDescendingOrderOfMaxElements(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                FindMaxElement(array[i]);
            }
            MyQuickSort(array, 0, array.Length, false);
        }

    }
}

