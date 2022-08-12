using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDeConta
{
    public static class RecebeValores
    {
        public static Pedido Pedido(Pedido pedido)
        {
            string[] vet = Console.ReadLine().Split(' ');

            pedido.Codigo = int.Parse(vet[0]);

            pedido.Quantidade = int.Parse(vet[1]);

            return pedido;

        }

    }
}
