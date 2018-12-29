using AutoMapper;
using CursoCore.Application.ViewModels;
using CursoCore.CrossCutting.Extensions;
using CursoCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCore.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>()
                 .ConvertUsing((src, dst) =>
                 {
                     return new ClienteViewModel
                     {
                         Id = src.Id,
                         Apelido = src.Apelido,
                         Nome = src.Nome,
                         CpfCnpj = src.CpfCnpj.Numero.FormatoCpfCnpj(),
                         Email = src.Email.Endereco,
                         Endereco = src.Endereco.Lograoudo,
                         Bairro = src.Endereco.Bairro,
                         Cidade = src.Endereco.Cidade,
                         UF = src.Endereco.UF.UF,
                         CEP = src.Endereco.CEP
                     };
                 });


            CreateMap<Fornecedor, FornecedoresViewModel>()
                 .ConvertUsing((src, dst) =>
                 {
                     return new FornecedoresViewModel
                     {
                         Id = src.Id,
                         Apelido = src.Apelido,
                         Nome = src.Nome,
                         CpfCnpj = src.CpfCnpj.Numero.FormatoCpfCnpj(),
                         Email = src.Email.Endereco,
                         Endereco = src.Endereco.Lograoudo,
                         Bairro = src.Endereco.Bairro,
                         Cidade = src.Endereco.Cidade,
                         UF = src.Endereco.UF.UF,
                         CEP = src.Endereco.CEP
                     };
                 });

            CreateMap<Produto, ProdutosViewModel>()
                    .ForMember(to => to.Valor, opt => opt.MapFrom(from => from.Valor.Formatado("{0:#,###,##0.00}")));

            CreateMap<Pedido, PedidosViewModel>()
                    .ForMember(to => to.DataPedido, opt => opt.MapFrom(from => from.DataPedido.Formatado("{0:dd/MM/yyyy}")))
                    .ForMember(to => to.DataEntrega, opt => opt.MapFrom(from => from.DataEntrega.Formatado("{0:dd/MM/yyyy}")));

            CreateMap<ItensPedido, ItensPedidosViewModel>();
        }
    }
}
