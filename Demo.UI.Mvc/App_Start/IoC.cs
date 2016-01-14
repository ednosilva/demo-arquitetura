using System.Web.Mvc;
using Demo.Aplicacao;
using Demo.Dominio.Servicos;
using Demo.Infraestrutura.Repositorio;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using Demo.Aplicacao.Compartilhado;
using Demo.Dominio.Repositórios;
using Demo.Infraestrutura.Configuracao;

namespace Demo.UI.Mvc
{
    public static class IoC
    {
        private static Container container;

        public static void Start()
        {
            container = new Container();

            container.Register<IServicoDeAplicacaoDeProduto, ServicoDeAplicacaoDeProduto>();
            container.Register<IServicoDeAplicacaoDeCliente, ServicoDeAplicacaoDeCliente>();
            container.Register<IServicoDeAplicacaoDaTransportadora, ServicoDeAplicacaoDaTransportadora>();
            container.Register<IServicoDeCadastroDeProduto, ServicoDeCadastroDeProduto>();

            container.Register<IRepositorioDeCliente, RepositorioDeCliente>();
            container.Register<IRepositorioDeContasAReceber, RepositorioDeContasAReceber>();
            container.Register<IRepositorioDeProduto, RepositorioDeProduto>();
            container.Register<IRepositorioDeRepresentante, RepositorioDeRepresentante>();
            container.Register<IRepositorioDeTransportadora, RepositorioDeTransportadora>();
            container.Register<IRepositorioDeVenda, RepositorioDeVenda>();

            container.Register<ContextoBanco>(() => new GerenciadorDeContextoBancoHttp().Contexto);
            container.Register<IFabricaDeUnidadeDeTrabalho, FabricaDeUnidadeDeTrabalhoEF>();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        public static TServico Obter<TServico>() where TServico : class
        {
            return container.GetInstance<TServico>();
        }
    }
}