using System;

namespace triang0 {
    class Program {
        static void Main(string[] args) {
            int a, b, c, s;
            double area;

            Console.WriteLine("Escreva lado A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva lado B:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva lado C:");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b + c || b > c + a || c > a + b) {
                Console.WriteLine("Não é triangulo");
            }
            else {
                s = (a + b + c) / 2;
                area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("É um triángulo");
                Console.WriteLine($"A área equivale a {area:F2}"); //Template string
                if (a == b && b == c) {
                    Console.WriteLine("Triangulo équilatero");
                }

                else if (a != b && b != c) {
                    Console.WriteLine("Escaleno");
                }

                else if (a == b || b == c || a == c) {
                    Console.WriteLine("Isóceles");
                }
            }
        }
    }
}