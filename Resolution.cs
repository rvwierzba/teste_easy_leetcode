using System;
using System.Linq;

public class Solution {
    public bool DetectCapitalUse(string word) {
        if (string.IsNullOrEmpty(word)) {
            return true; // Palavra vazia é considerada válida
        }

        int n = word.Length;

        // Verifica se todas são maiúsculas
        if (word.All(char.IsUpper)) {
            return true;
        }

        // Verifica se todas são minúsculas
        if (word.All(char.IsLower)) {
            return true;
        }

        // Verifica se apenas a primeira é maiúscula
        if (char.IsUpper(word[0]) && word.Substring(1).All(char.IsLower)) {
            return true;
        }

        return false; // Se nenhuma das condições acima for satisfeita, retorna falso
    }

    public static void Main(string[] args) {
        Solution solution = new Solution();

        // Testes
        Console.WriteLine(solution.DetectCapitalUse("USA")); // Saída: True
        Console.WriteLine(solution.DetectCapitalUse("FlaG")); // Saída: False
        Console.WriteLine(solution.DetectCapitalUse("leetcode")); // Saída: True
        Console.WriteLine(solution.DetectCapitalUse("Google")); // Saída: True
        Console.WriteLine(solution.DetectCapitalUse("")); // Saída: True
        Console.WriteLine(solution.DetectCapitalUse("mL")); // Saída: False
        Console.WriteLine(solution.DetectCapitalUse("Coding")); // Saída: True
        Console.WriteLine(solution.DetectCapitalUse("coding")); // Saída: True
        Console.WriteLine(solution.DetectCapitalUse("CODE")); // Saída: True
    }
}
