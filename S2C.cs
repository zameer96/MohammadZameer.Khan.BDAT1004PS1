/*
 * 2.C > Which of the following words is the longest:
    Supercalifragilisticexpialidocious, Honorificabilitudinitatibus, or
    Bababadalgharaghtakamminarronnkonn?
*/

using System;
class Solution2C {
    static void Main() {
        string str1 = "Supercalifragilisticexpialidocious";
        string str2 = "Honorificabilitudinitatibus";
        string str3 = "Bababadalgharaghtakamminarronnkonn";

        string longest_word = "";

        if (str1.Length > longest_word.Length) {
            longest_word = str1;
        }
        if (str2.Length > longest_word.Length) {
            longest_word = str2;
        }
        if (str3.Length > longest_word.Length) {
            longest_word = str3;
        }
        Console.WriteLine(longest_word);
    }
}
