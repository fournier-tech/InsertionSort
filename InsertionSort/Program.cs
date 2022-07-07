using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsertionSort {
    class Program {
        static void Main(string[] args) {

            int[] integerArray = { -6, 5, -6, 0, 3, -10, 4, 6, 5, 0 };

            Console.WriteLine("\nUnsorted List of Integers: ");
            PrintList(integerArray);
            Console.WriteLine("\nSorted List of Integers: ");
            PrintList(InsertionSort(integerArray));

            Console.WriteLine("\n");
        }

        //InsertionSort(A[])
        //for i = 1 to A.Length
        //key = A[i]
        //while j >= 0 and A[i] > key
        //  A[j + 1] = A[i]
        //  j = j - 1
        //A[j + 1] = key

        public static int[] InsertionSort(int[] integerArray) {

            int temp;
            int j;

            for (int i = 1; i < integerArray.Length; i++) {

                temp = integerArray[i];
                j = i - 1;

                while (j >= 0 && integerArray[j] > temp) {
                    integerArray[j + 1] = integerArray[j];
                    j--;
                }
                integerArray[j + 1] = temp;
            }
            return integerArray;
        }

        public static void PrintList(int[] integerArray) {

            foreach (int i in integerArray) {
                Console.Write(i + " ");
            }
        }
    }
}