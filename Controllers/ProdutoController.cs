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
    public class ProdutoController : ControllerBase
    {
        [HttpGet("listar")]

        public ActionResult Listar()
        {
            ProdutoService service = new ProdutoService(); 
            var produto = service.Listar();

            ObjectResult objetoRetorno = new ObjectResult(produto);
            return objetoRetorno;

        }

        [HttpGet("obter")]
        public ActionResult Obter([FromQuery] int Id)
        {
            ProdutoService service = new ProdutoService(); 
            var produto = service.Obter(Id);

            ObjectResult objetoRetorno = new ObjectResult(produto);
            return objetoRetorno;

        }

        [HttpPost("inserir")]
        public ActionResult Inserir([FromBody] Produto produto)
        {
            ProdutoService service = new ProdutoService();
            service.Inserir(produto);


            ObjectResult objetoRetorno = new ObjectResult(new { });
            return objetoRetorno;

        }

        [HttpPut("atualizar")]
        public ActionResult Atualizar([FromBody] Produto produto)
        {
            ProdutoService service = new ProdutoService();
            service.Atualizar(produto);


            ObjectResult objetoRetorno = new ObjectResult(new { });
            return objetoRetorno;

        }

        [HttpDelete("deletar")]
        public ActionResult Deletar([FromQuery] int Id)
        {
            ProdutoService service = new ProdutoService();
            service.Deletar(Id);


            ObjectResult objetoRetorno = new ObjectResult(new { });
            return objetoRetorno;

        }



    }
}
