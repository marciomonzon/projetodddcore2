using AutoMapper;
using CursoCore.Application.ViewModels;
using CursoCore.CrossCutting.Extensions;
using CursoCore.Domain.Entities;
using CursoCore.Domain.Shared.ValueObjects;
using System;

namespace CursoCore.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>()
                 .ConvertUsing((src, dst) =>
                 {
                     return new Cliente
                     {
                         Id = src.Id,
                         Apelido = src.Apelido,
                         Nome = src.Nome,
                         CpfCnpj = new CpfCnpjVO
                         {
                             Numero = src.CpfCnpj.SomenteNumeros()
                         },
                         Email = new EmailVO
                         {
                             Endereco = src.Email
                         },
                         Endereco = new EnderecoVO
                         {
                             Lograoudo = src.Endereco,
                             Bairro = src.Bairro,
                             Cidade = src.Cidade,
                             CEP = src.CEP,
                             UF = new UfVO
                             {
                                 UF = src.UF
                             }
                         }
                     };
                 });

            CreateMap<FornecedoresViewModel, Fornecedor>()
                 .ConvertUsing((src, dst) =>
                 {
                     return new Fornecedor
                     {
                         Id = src.Id,
                         Apelido = src.Apelido,
                         Nome = src.Nome,
                         CpfCnpj = new CpfCnpjVO
                         {
                             Numero = src.CpfCnpj.SomenteNumeros()
                         },
                         Email = new EmailVO
                         {
                             Endereco = src.Email
                         },
                         Endereco = new EnderecoVO
                         {
                             Lograoudo = src.Endereco,
                             Bairro = src.Bairro,
                             Cidade = src.Cidade,
                             CEP = src.CEP,
                             UF = new UfVO
                             {
                                 UF = src.UF
                             },
                         }
                     };
                 });

            CreateMap<ProdutosViewModel, Produto>()
                    .ForMember(to => to.Valor, opt => opt.MapFrom(from => from.Valor.ConverteParaDecimal("{0:#,###,##0.00}")));

            CreateMap<PedidosViewModel, Pedido>()
                    .ForMember(to => to.DataPedido, opt => opt.MapFrom(from => Convert.ToDateTime(from.DataPedido)))
                    .ForMember(to => to.DataEntrega, opt => opt.MapFrom(from => Convert.ToDateTime(from.DataEntrega)));

            CreateMap<ItensPedidosViewModel, ItensPedido>();
        }
    }
}
