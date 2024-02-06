/*
Write a program in C# Sharp to separate odd and even integers in separate arrays.
Go to the editor
Test Data :
Input the number of elements to be stored in the array :5
Input 5 elements in the array :
element - 0 : 25
element - 1 : 47
element - 2 : 42
element - 3 : 56
element - 4 : 32
Expected Output:
The Even elements are:
42 56 32
The Odd elements are :
25 47
*/


using System;

class Solution4 {
    static void Main() {
        Console.Write("Input the number of elements to be stored in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine($"Input {n} elements in the array:");
        for (int i = 0; i < n; i++) {
            Console.Write($"element - {i} : ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] evenArray = new int[n];
        int[] oddArray = new int[n];
        int evenCount = 0;
        int oddCount = 0;

        foreach (int num in array) {
            if (num % 2 == 0) {
                evenArray[evenCount] = num;
                evenCount++;
            }
            else {
                oddArray[oddCount] = num;
                oddCount++;
            }
        }
        
        // show even elements
        Console.Write("\nThe Even elements are:\n");
        for (int i = 0; i < evenCount; i++) {
            Console.Write($"{evenArray[i]} ");
        }

        // Show odd elements
        Console.Write("\nThe Odd elements are:\n");
        for (int i = 0; i < oddCount; i++) {
        Console.Write($"{oddArray[i]} ");
        }
    }
}
