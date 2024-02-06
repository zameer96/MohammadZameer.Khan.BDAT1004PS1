/* 
Write a function inside(x,y,x1,y1,x2,y2) that returns True or False
depending on whether the point (x,y) lies in the rectangle with lower left
corner (x1,y1) and upper right corner (x2,y2).
>>> inside(1,1,0,0,2,3)
True
>>> inside(-1,-1,0,0,2,3)
False
*/

using System;

class Solution5A {
    static void Main() {
        Console.Write("Inout x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("INput y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input x1: ");
        int x1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input y1: ");
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input x2: ");
        int x2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input y2: ");
        int y2 = Convert.ToInt32(Console.ReadLine());

        bool result = inside(x, y, x1, y1, x2, y2);
        Console.WriteLine($"inside({x}, {y}, {x1}, {y1}, {x2}, {y2}):\n{result}");
    }

    static bool inside(int x, int y, int x1, int y1, int x2, int y2) {
        return x1 <= x && x <= x2 && y1 <= y && y <= y2;
    }
}
