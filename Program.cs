using System;
using System.IO;
using System.Linq;
namespace Aufgabe_9;

using System;

class Program
{
    static void Main(string[] args)
    {
       
        if (args.Length < 1)
        {
            Console.WriteLine("Не указан путь к текстовому файлу.");
            return;
        }
       

        Console.WriteLine(" путь к файлу");
        string filePath = args[0];
        string[] lines;

        try
        {
            lines = System.IO.File.ReadAllLines(filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка при чтении файла: " + ex.Message);
            return;
        }

        Array.Sort(lines);

        Console.WriteLine("Отсортированный список:");

        foreach (string line in lines)
        {
            Console.Write(line + " ");
        }
    }
}
