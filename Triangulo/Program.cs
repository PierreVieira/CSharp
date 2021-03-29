using System;

namespace Triangulo {
    class Program {
        private static void Main() {
            double lx1, lx2, lx3, ly1, ly2, ly3, areaX, areaY;

            do {
                Console.WriteLine("Entre com as medidas do triângulo X: ");
                lx1 = LerLadoTriangulo(1);
                lx2 = LerLadoTriangulo(2);
                lx3 = LerLadoTriangulo(3);
            } while (!FormaTriangulo(lx1, lx2, lx3));

            do {
                Console.WriteLine("Entre com as medidas do triângulo Y: ");
                ly1 = LerLadoTriangulo(1);
                ly2 = LerLadoTriangulo(2);
                ly3 = LerLadoTriangulo(3);
            } while (!FormaTriangulo(ly1, ly2, ly3));

            areaX = CalcularAreaTriangulo(lx1, lx2, lx3);
            areaY = CalcularAreaTriangulo(ly1, ly2, ly3);

            InformarMaiorArea(areaX, areaY);
        }

        private static bool FormaTriangulo(in double lx1, in double lx2, in double lx3) {
            return lx1 < lx2 + lx3 && lx2 < lx1 + lx3 && lx3 < lx1 + lx2;
        }

        private static void InformarMaiorArea(double areaX, double areaY) {
            Console.WriteLine($"Área do triângulo X: {areaX:F4}");
            Console.WriteLine($"Área do triângulo Y: {areaY:F4}");
            if (areaX > areaY) {
                Console.WriteLine("Área maior: triângulo X.");
            }
            else if (areaX < areaY) {
                Console.WriteLine("Área maior: triângulo Y.");
            }
            else {
                Console.WriteLine("Os triângulos tem áreas iguais.");
            }
        }

        private static double CalcularAreaTriangulo(double a, double b, double c) {
            double p, area;
            p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        private static double LerLadoTriangulo(int side) {
            Console.Write($"Lado {side}: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}