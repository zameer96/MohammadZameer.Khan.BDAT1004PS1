/*
Use function inside() from part a. to write an expression that tests whether
the point (1,1) lies in both of the following rectangles: one with lower left
corner (0.3, 0.5) and upper right corner (1.1, 0.7) and the other with lower
left corner (0.5, 0.2) and upper right corner (1.1, 2).
*/

using System;

class Solution5B {
    static void Main() {
        int x = 1;
        int y = 1;

        double x1R1 = 0.3;
        double y1R1 = 0.5;
        double x2R1 = 1.1;
        double y2R1 = 0.7;

        double x1R2 = 0.5;
        double y1R2 = 0.2;
        double x2R2 = 1.1;
        double y2R2 = 2;

        bool isInRect1 = inside(x, y, x1R1, y1R1, x2R1, y2R1);
        if (isInRect1) {
            Console.WriteLine($"The point ({x}, {y}) is inside Rectangle R1.");
        }
        else {
            Console.WriteLine($"The point ({x}, {y}) is not inside Rectangle R1.");
        }

        bool isInRect2 = inside(x, y, x1R2, y1R2, x2R2, y2R2);
        if (isInRect2) {
            Console.WriteLine($"The point ({x}, {y}) is inside Rectangle R2.");
        }
        else {
            Console.WriteLine($"The point ({x}, {y}) is not inside Rectangle R2.");
        }
    }

    static bool inside(int x, int y, double x1, double y1, double x2, double y2) {
        return x1 <= x && x <= x2 && y1 <= y && y <= y2;
    }
}
