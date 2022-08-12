using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDeConta
{
    public static class Calculadora
    {
        
        public static double Total { get; set; }

        public static double TotalPedido(Pedido pedido )
        {

       
            double Total = pedido.Preco * pedido.Quantidade;
            
            return Total;
        }


    }
}

