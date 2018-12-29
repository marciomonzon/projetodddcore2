using AutoMapper;
using CursoCore.Application.Interfaces;
using CursoCore.Application.ViewModels;
using CursoCore.Domain.Entities;
using CursoCore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoCore.Application.Services
{
    public class ApplicationCliente : IApplicationCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapper _mapper;

        public ApplicationCliente(IServiceCliente serviceCliente, IMapper mapper)
        {
            _serviceCliente = serviceCliente;
            _mapper = mapper;
        }

        public ClienteViewModel Adicionar(ClienteViewModel obj)
        {
            var cliente = _mapper.Map<Cliente>(obj);
            _serviceCliente.Adicionar(cliente);

            return _mapper.Map<ClienteViewModel>(cliente);
        }

        public ClienteViewModel Atualizar(ClienteViewModel obj)
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel Remover(ClienteViewModel obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteViewModel> Buscar(Expression<Func<ClienteViewModel, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel ObterPorApelido(string apelido)
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel ObterPorCpfCnpj(string cpfcnpj)
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            var cliente = _serviceCliente.ObterTodos();
            return _mapper.Map<IEnumerable<ClienteViewModel>>(cliente);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
