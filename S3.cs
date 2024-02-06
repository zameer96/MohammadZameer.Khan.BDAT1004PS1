/*
Implement function triangleArea(a,b,c) that takes as input the lengths of the 3
sides of a triangle and returns the area of the triangle. By Heron's formula, the area
of a triangle with side lengths a, b, and c is
s(s - a)(s -b)(s -c)
, where

s = (a+b+c)/2.
>>> triangleArea(2,2,2)
1.7320508075688772

*/

using System;

class Solution3 {
    static void Main() {
        Console.Write("Input A: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input C: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double result = GetTriangleArea(a, b, c);

        Console.WriteLine($"The area of the triangle with sides {a}, {b}, and {c} is: {result}");
    }

    static double GetTriangleArea(double a, double b, double c) {
        double s = (a + b + c) / 2;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        return area;
    }
}
