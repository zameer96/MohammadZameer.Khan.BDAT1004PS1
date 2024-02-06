/*
 * 2.D> Which composer comes first in the dictionary: 'Berlioz', 'Borodin', 'Brian',
    'Bartok', 'Bellini', 'Buxtehude', 'Bernstein'. Which one comes last?
*/

using System;

class Solution2D {
    static void Main() {
        string[] composers = { "Berlioz", "Borodin", "Brian", "Bartok", "Bellini", "Buxtehude", "Bernstein" };

        Array.Sort(composers);
        string frist_comp = composers[0];
        string last_comp = composers[composers.Length - 1];
        Console.WriteLine("first composer:");
        Console.WriteLine(frist_comp);
        Console.WriteLine("last composer: ");
        Console.WriteLine(last_comp);
    }
}