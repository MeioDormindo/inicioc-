using System;
using System.Globalization;

namespace Program3
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            // Versao 1 - Utilizando estatico na classe main
            Console.WriteLine("Versao 1 - Utilizando estatico na classe main.");
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circunferencia(raio);
            double volume = Volume(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            // Versao 2 - Utiliza classe sem metodos estaticos e instancia o objeto
            Console.WriteLine("Versao 2 - Utiliza classe sem metodos estaticos e instancia o objeto.");
            Calcular calc = new Calcular();
            Console.Write("Entre o valor do raio: ");
            double raio2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ2 = calc.Circunferencia(raio);
            double volume2 = calc.Volume(raio);
            Console.WriteLine("Circunferência: " + circ2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            // Versao 3 - Utiliza classe com metodos estaticos e nao precisa instancia o objeto
            Console.WriteLine("Versao 3 - Utiliza classe com metodos estaticos e nao precisa instancia o objeto.");
            Console.Write("Entre o valor do raio: ");
            double raio3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ3 = CalcStatic.Circunferencia(raio);
            double volume3 = CalcStatic.Volume(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + CalcStatic.Pi.ToString("F2",
            CultureInfo.InvariantCulture));


        }


        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
 }

