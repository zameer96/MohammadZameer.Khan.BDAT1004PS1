// 2.A > How many letters are there in 'Supercalifragilisticexpialidocious'?

using System;

class Solution2A {
    static void Main() {
        string str = "Supercalifragilisticexpialidocious";       
        int numberOfLetters = CountLetters(str);
        Console.WriteLine($"The number of letters in '{str}' is: {numberOfLetters}");
    }

    static int CountLetters(string input) {
        int letterCount = 0;
        foreach (char character in input) {
            if (char.IsLetter(character)) {
                letterCount++;
            }
        }
        return letterCount;
    }
}