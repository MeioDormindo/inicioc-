using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Tamanho da lista " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeirp/a com a lentra 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo/a com a lentra 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Numero da posicao onde o primeiro que inicia com 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Numero da posicao onde o ultimo que inicia com 'A': " + pos2);


            // List com nonme de 5 ou mais caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);

            Console.WriteLine("----------List 2---------");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }


            list.Remove("Alex");

            Console.WriteLine("---------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remove todos que iniciam com a letra M
            list.RemoveAll(x => x[0] == 'M');

            Console.WriteLine("---------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}