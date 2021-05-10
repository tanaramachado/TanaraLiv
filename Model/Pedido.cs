using System;
using System.Collections.Generic;
using System.Text;

namespace TanaraLiv.Model
{
   public class Pedido
    {
        public int Id { get; set; }
        public string NumeroPedido { get; set; }
        public string Valor { get; set; }
        public string Desconto{ get; set; }
        public string ValorLiquido { get; set; }
   
    }
}
