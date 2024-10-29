using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce una frase:");
        string frase = Console.ReadLine();
        int vocalesSinTilde = 0;
        int vocalesConTilde = 0;

        Dictionary<char, int> conteoVocales = new Dictionary<char, int> 
            {
                {'a', 0}, {'e', 0}, {'i', 0}, {'o', 0}, {'u', 0}, 
            };

        foreach (char c in frase)
        {
            if (conteoVocales.ContainsKey(c)) 
            { 
                conteoVocales[c]++; 
            }
                if ("aeiou".Contains(c))
                {
                    vocalesSinTilde++;
                }
                else if ("áéíóú".Contains(c))
                {
                    vocalesConTilde++;
                }

            switch (c) 
            {
                case 'á': 
                    conteoVocales['a']++; 
                    break; 

                case 'é': 
                    conteoVocales['e']++; 
                    break; 

                case 'í': 
                    conteoVocales['i']++; 
                    break; 

                case 'ó': 
                    conteoVocales['o']++; 
                    break; 

                case 'ú': 
                    conteoVocales['u']++; 
                    break; 
            }
        }

        int totalVocales = conteoVocales.Values.Sum();

        Console.WriteLine("Conteo de vocales:"); 
        foreach (var vocal in conteoVocales) 
        { 
            Console.WriteLine($"{vocal.Key}: {vocal.Value}"); 
        }
        Console.WriteLine($"Vocales sin tilde: {vocalesSinTilde}");
        Console.WriteLine($"Vocales con tilde: {vocalesConTilde}");
        Console.WriteLine($"Total de vocales: {totalVocales}");
    }
}




