﻿using AutoMapper;
using DFK.Application.Interfaces.Cliente;
using DFK.Application.ViewModel.Cliente;
using DFK.Domain.Entities.Cliente;
using DFK.Domain.Interfaces.Services.Cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace DFK.Application.Services.Cliente
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IMapper _mapper;
        private readonly IClienteService _clienteService;

        public ClienteAppService( IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }

        public long Create(ClienteViewModel cliente)
        {
            return _clienteService.Create(_mapper.Map<ClienteModel>(cliente));
        }

        public ClienteViewModel GetById( long clienteId)
        {
            return _mapper.Map<ClienteViewModel>(_clienteService.GetById(clienteId));
        }
    }
}
