﻿using Demo.Dominio.Vendas;
using System;
using System.Web;
using System.Web.Routing;

namespace Demo.UI.Mvc.Infra
{
    public class RestriçãoDeRotaProduto : IRouteConstraint
    {
        #region IRouteConstraint Members

        public bool Match(HttpContextBase httpContext, Route route,
                          string parameterName, RouteValueDictionary values,
                          RouteDirection routeDirection)
        {
            var controller = (string) values["controller"];
            var action = (string) values["action"];

            if ("produto".Equals(controller, StringComparison.InvariantCultureIgnoreCase) &&
                "deletar".Equals(action, StringComparison.InvariantCultureIgnoreCase))
            {
                var repositorio = IoC.Obter<IRepositorioDeProduto>();

                var nome = (string) values["nome"];
                var produto = repositorio.ObterProdutoPorNome(nome);

                return produto.Preço <= 1000;
            }

            return true;
        }

        #endregion
    }
}