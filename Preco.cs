using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDeConta
{
    class Preco
    {
        public static Pedido ValorPorCodigo(Pedido pedido)
        {

            switch (pedido.Codigo)
            {
                case 1:
                    pedido.Preco = 4.00;
                    break;

                case 2:
                    pedido.Preco = 4.50;
                    break;

                case 3:
                    pedido.Preco = 5.00;
                    break;

                case 4:
                    pedido.Preco = 2.00;
                    break;

                case 5:
                    pedido.Preco = 1.50;
                    break;

                default:
                    break;
            }

            return pedido;
        }
    }
}
