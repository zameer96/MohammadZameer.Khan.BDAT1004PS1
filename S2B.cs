/*
 * 
 * 2.B > Does 'Supercalifragilisticexpialidocious' contain 'ice' as a substring? 
*/


using System;

class Soultion2B {
    static void Main() {
        string str = "Supercalifragilisticexpialidocious";
        string sub = "ice";
        bool ans = str.Contains(sub);

        Console.WriteLine(ans);
    }
}