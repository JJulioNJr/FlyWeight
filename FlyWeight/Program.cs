using System;

namespace FlyWeight {
    internal class Program {
        static void Main(string[] args) {


            Sanduiches lista = new Sanduiches();


            Console.WriteLine("\n**** CARDÁPIO ****\n");
            Console.WriteLine("Pedido: {0}", lista[1]);
            Console.WriteLine("Pedido: {0}", lista[2]);
            Console.WriteLine("Pedido: {0}", lista[3]);
            
            Console.ReadKey();
        }
    }
}
