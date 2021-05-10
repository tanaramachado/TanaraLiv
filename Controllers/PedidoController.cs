using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TanaraLiv.Model;
using TanaraLiv.Service;
using Microsoft.AspNetCore.Mvc;

namespace TanaraLiv.Controller
{
    [Route("[controller]")]
   public class PedidoController : ControllerBase
    {
        [HttpGet("listar")]
        public ActionResult Listar()

        {
            PedidoService service = new PedidoService(); 
            var pedido = service.Listar();

            ObjectResult objetoRetorno = new ObjectResult(pedido);
            return objetoRetorno;

        }
        public ActionResult Obter()
        {
            PedidoService service = new PedidoService(); 
            var pedido = service.Listar();

            ObjectResult objetoRetorno = new ObjectResult(pedido);
            return objetoRetorno;

        }
    }
}
