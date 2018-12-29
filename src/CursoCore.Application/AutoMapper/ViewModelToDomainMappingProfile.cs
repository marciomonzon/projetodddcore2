using AutoMapper;
using CursoCore.Application.ViewModels;
using CursoCore.CrossCutting.Extensions;
using CursoCore.Domain.Entities;
using System;

namespace CursoCore.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>()
                .ForPath(to => to.CpfCnpj.Numero.SomenteNumeros(), opt => opt.MapFrom(from => from.CpfCnpj))
                .ForPath(to => to.Email.Endereco, opt => opt.MapFrom(from => from.Email))
                .ForPath(to => to.Endereco.Lograoudo, opt => opt.MapFrom(from => from.Endereco))
                .ForPath(to => to.Endereco.Bairro, opt => opt.MapFrom(from => from.Bairro))
                .ForPath(to => to.Endereco.Cidade, opt => opt.MapFrom(from => from.Cidade))
                .ForPath(to => to.Endereco.UF.UF, opt => opt.MapFrom(from => from.UF))
                .ForPath(to => to.Endereco.CEP.SomenteNumeros(), opt => opt.MapFrom(from => from.CEP));

            CreateMap<FornecedoresViewModel, Fornecedor>()
                .ForPath(to => to.CpfCnpj.Numero.SomenteNumeros(), opt => opt.MapFrom(from => from.CpfCnpj))
                .ForPath(to => to.Email.Endereco, opt => opt.MapFrom(from => from.Email))
                .ForPath(to => to.Endereco.Lograoudo, opt => opt.MapFrom(from => from.Endereco))
                .ForPath(to => to.Endereco.Bairro, opt => opt.MapFrom(from => from.Bairro))
                .ForPath(to => to.Endereco.Cidade, opt => opt.MapFrom(from => from.Cidade))
                .ForPath(to => to.Endereco.UF.UF, opt => opt.MapFrom(from => from.UF))
                .ForPath(to => to.Endereco.CEP.SomenteNumeros(), opt => opt.MapFrom(from => from.CEP));

            CreateMap<ProdutosViewModel, Produto>()
                .ForMember(to => to.Valor, opt => opt.MapFrom(from => from.Valor.ConverteParaDecimal("{0:#,###,##0.00}")));

            CreateMap<PedidosViewModel, Pedido>()
                .ForMember(to => to.DataPedido, opt => opt.MapFrom(from => Convert.ToDateTime(from.DataPedido)))
                .ForMember(to => to.DataEntrega, opt => opt.MapFrom(from => Convert.ToDateTime(from.DataEntrega)));

            CreateMap<ItensPedidosViewModel, ItensPedido>();
        }
    }
}
