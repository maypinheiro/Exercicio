using System;

namespace CalculadoraDeConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();
            Menu();
            RecebeValores.Pedido(pedido);
            Preco.ValorPorCodigo(pedido);
            Console.WriteLine("Total: R$ " +Calculadora.TotalPedido(pedido).ToString("F2"));
        }



        static void Menu()
        {
            Console.Clear();
            Console.WriteLine(" ------------------------------------- ");
            Console.WriteLine(" CÓDIGO     ESPECIFICAÇÃO     PREÇO");
            Console.WriteLine("   1        Cachorro Quente   R$ 4.00 ");
            Console.WriteLine("   2        X-Salada          R$ 4.50 ");
            Console.WriteLine("   3        X-Bacon           R$ 5.00 ");
            Console.WriteLine("   4        Torrada Simples   R$ 2.00");
            Console.WriteLine("   5        Refrigerante      R$ 1.50 ");
            Console.WriteLine(" ------------------------------------- ");

        }


    }
}
