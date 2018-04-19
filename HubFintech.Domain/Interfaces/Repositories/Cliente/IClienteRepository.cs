﻿using HubFintech.Domain.Entities.Cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace HubFintech.Domain.Interfaces.Repositories.Cliente
{
    public interface IClienteRepository
    {
        void Create(ClienteModel cliente);
        ClienteModel GetById(long clienteId);
        ClienteModel GetByCPF(string cpf);
        ClienteModel GetByCNPJ(string cnpj);
    }
}
