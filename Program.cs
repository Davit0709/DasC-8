using System;

class Program {
   
    static int Cube(int n) {
        return n * n * n;
    }

   
    static void PrintCubes(int N) {
        Console.WriteLine("Таблица кубов чисел от 1 до {0}:", N);
        for (int i = 1; i <= N; i++) {
            Console.Write(Cube(i) + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args) {
        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        PrintCubes(N);
    }
}
