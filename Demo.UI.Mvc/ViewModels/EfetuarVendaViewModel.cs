using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Demo.Aplicacao;
using Demo.Aplicacao.Participantes;

namespace Demo.UI.Mvc.ViewModels
{
    public class EfetuarVendaViewModel
    {
        public EfetuarVendaViewModel()
        {
            Transportadoras = new SelectList(CriarListaDeTransportadoras(),
                                             "Value", "Text", Transportadora);
        }

        [DisplayName("Número da nota")]
        public int? NumeroDeNota { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal? Valor { get; set; }

        public string Descrição { get; set; }

        public int Transportadora { get; set; }
        public SelectList Transportadoras { get; set; }

        public int Cliente { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Data de emissão")]
        public DateTime? DataDeEmissao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Data de saída")]
        public DateTime? DataDeSaida { get; set; }

        private IEnumerable<SelectListItem> CriarListaDeTransportadoras()
        {
            yield return new SelectListItem {Text = "--SELECIONE--", Value = ""};

            var servicoDeTransportadora = IoC.Obter<ServicoDeAplicacaoDaTransportadora>();
            foreach (var transportadora in servicoDeTransportadora.RecuperarTodasAsTransportadoras())
            {
                yield return new SelectListItem {Text = transportadora.Nome, Value = transportadora.Id.ToString()};
            }
        }
    }
}