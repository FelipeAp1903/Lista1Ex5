using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Double n1;
            Double n2;
            Double n3;
            Double n4;
            Double soma;
            Double media;
            Double Resultado;
            Console.WriteLine("coloque o primeiro valor:");
            n1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("coloque o segundo valor:");
            n2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("coloque o terceiro valor:");
            n3 = Double.Parse(Console.ReadLine());
            Console.WriteLine("coloque o quarto valor:");
            n4 = Double.Parse(Console.ReadLine());
            soma = n1 + n2 + n3 + n4;
            media = soma / 4;
            Resultado = media;
            Console.WriteLine("A media Aritmética é:");
            Console.WriteLine(media);
        }
    }
}
