using System;

namespace CalculadoraRefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Método Ref  deve ser iniciado o parametro
            int a = 10;
            Calculator.TripleRef(ref a);
            Console.WriteLine(a);

            //Método out não precisa ser iniciado
            int b = 10;
            int triple;
            Calculator.TripleOut(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
