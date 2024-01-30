using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GA_SelectionSort_EdnaLynnLaxa
{
    internal class Program
    {
        //Edna Lynn Laxa ; Computer Programming V ; Assignment Selection Sort ; Janaury 28, 2024 
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11, 36, 8, 42, 5, 38 }; // Initializing an array ; int focused. 

            Console.WriteLine("Original Array:"); // Titling original array 
            PrintArray(arr); // Calling method print array to display the elemnt of the named variable arr which will prompt a collection of numbers 

            SelectionSortArray(arr); // This part calls the method titled SelectionSortArray in which will dispaly the numeric collection in an ascending order

            Console.WriteLine("\nSorted Array:"); // Displaying Sorted Array 
            PrintArray(arr); // Calling the print array w/ called parameter arr to display now sorted elements. 
        }

        static void PrintArray(int[] arr) // Declares a static method that accepts an integer array 
        {
            foreach (var item in arr) // Iterates through each collection of an array 
            {
                Console.Write(item + " "); // This will display the item array 
            }
            Console.WriteLine();
        }

        static void SelectionSortArray(int[] arr)
        {
            // Step 1 - Initialization
            //In this step, we obtain the length of the input array arr, which helps us determine the number of elements in the array.
            int arrayLength = arr.Length;

            //Step 2: Outer Loop
            //We start an outer loop that iterates through the array from the first element (index 0) to the
            //second-to-last element (index arrayLength - 2). This loop will help us select each element one by one for proper placement.
            for (int currentIndex = 0; currentIndex < arrayLength - 1; currentIndex++)
            {
                int minIndex = currentIndex;

                // Find the minimum element in the remaining unsorted portion of the array
                for (int unsortedIndex = currentIndex + 1; unsortedIndex < arrayLength; unsortedIndex++)
                {
                    if (arr[unsortedIndex] < arr[minIndex])
                    {
                        //Step 3: Assumption of Minimum
                        //We initialize minIndex with the current index (currentIndex) to assume that the
                        //current element is the minimum within the unsorted portion of the array.
                        //This is a temporary minimum value until we find a smaller value.
                        minIndex = unsortedIndex;
                    }

                }
                //Step 4: Inner Loop 
                //Within the outer loop, we start an inner loop that iterates through the remaining unsorted portion of the array.
                //We begin from the element next to the current element (index currentIndex + 1)
                //and continue to the last element (index arrayLength - 1). This inner loop helps us find the minimum element within the unsorted part.
                for (int unsortedIndex = currentIndex + 1; unsortedIndex < arrayLength; unsortedIndex++)
                {
                    //Step 5: Comparison
                    //Inside the inner loop, we compare the element at the current unsortedIndex with the element at the minIndex
                    //(the assumed minimum). If the element at unsortedIndex is smaller than the assumed minimum, we update minIndex to point to the unsortedIndex.
                    //This step ensures we find the smallest element within the remaining unsorted portion of the array.


                    if (arr[unsortedIndex] < arr[minIndex])
                    {
                        minIndex = unsortedIndex;
                    }
                }
                //Step 6: Swap
                // Swap the found minimum element with the element at currentIndex
                //After completing the inner loop, we've found the actual minimum element within the unsorted part of the array.
                //We then swap this minimum element with the element at the currentIndex.
                //This step ensures that the smallest element is correctly placed at its sorted position at the beginning of the array.
                int temp = arr[minIndex];
                arr[minIndex] = arr[currentIndex];
                arr[currentIndex] = temp;

                //Step 7: For this exercise: Display what is happening. 
                // Display the current state of the array after each iteration
                //Finally, after each iteration of the outer loop, we display the current state of the array to visualize how the elements are being sorted.
                //This step helps us track the progress of the sorting process.
                //These steps work together to perform selection sort, where the algorithm repeatedly selects the minimum element 
                //from the unsorted portion of the array and moves it to the beginning of the sorted portion.
                //This process continues until the entire array is sorted.
                Console.Write($"Iteration {currentIndex + 1}: ");
                PrintArray(arr);
            }

            //My take 
            //I watched a youtube video on a dance that performs the operation of select sort. It seems to me that each lower number dance with all higher number until 
            // the dancer was placed in its proper location: https://www.youtube.com/watch?v=0-W8OEwLebQ (hopefully that is the right represenation) 

            //The selection sort algorithm continously searches through the range, replacing the smallest remaining integer with the first unsorted int after each 
            //iteration. This goes on until the data is complete and sorted. The process repeats. 
        }
    }
}

