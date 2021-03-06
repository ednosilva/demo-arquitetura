﻿using Demo.Dominio.Compartilhado;
using System.Collections.Generic;

namespace Demo.Dominio.Participantes
{
    public interface IRepositorioDeCliente : IRepositorioBase<Cliente>
    {
        IList<Cliente> RecuperarPorLimiteDeCredito(decimal limiteInicial, decimal limiteFinal);
    }
}