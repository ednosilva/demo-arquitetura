﻿using System.Web.Mvc;
using Demo.Aplicacao;
using Demo.Aplicacao.Participantes;

namespace Demo.UI.Mvc.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IServicoDeAplicacaoDeCliente _servicoDeAplicacaoDeCliente;

        public ClienteController(IServicoDeAplicacaoDeCliente servicoDeAplicacaoDeCliente)
        {
            _servicoDeAplicacaoDeCliente = servicoDeAplicacaoDeCliente;
        }

        public ActionResult RecuperarClientePorId(int idDoCliente)
        {
            var cliente = _servicoDeAplicacaoDeCliente.RecuperarClientePorId(idDoCliente);
            if (cliente == null)
            {
                return new EmptyResult();
            }
            return Json(cliente.Nome);
        }
    }
}