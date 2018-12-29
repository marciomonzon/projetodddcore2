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
                .ForMember(to => to.CpfCnpj, opt => opt.MapFrom(from => from.CpfCnpj.Numero.FormatoCpfCnpj()))
                .ForMember(to => to.Email, opt => opt.MapFrom(from => from.Email.Endereco))
                .ForMember(to => to.Endereco, opt => opt.MapFrom(from => from.Endereco.Lograoudo))
                .ForMember(to => to.Bairro, opt => opt.MapFrom(from => from.Endereco.Bairro))
                .ForMember(to => to.Cidade, opt => opt.MapFrom(from => from.Endereco.Cidade))
                .ForMember(to => to.UF, opt => opt.MapFrom(from => from.Endereco.UF))
                .ForMember(to => to.CEP, opt => opt.MapFrom(from => from.Endereco.CEP));

            CreateMap<Fornecedor, FornecedoresViewModel>()
                .ForMember(to => to.CpfCnpj, opt => opt.MapFrom(from => from.CpfCnpj.Numero))
                .ForMember(to => to.Email, opt => opt.MapFrom(from => from.Email.Endereco))
                .ForMember(to => to.Endereco, opt => opt.MapFrom(from => from.Endereco.Lograoudo))
                .ForMember(to => to.Bairro, opt => opt.MapFrom(from => from.Endereco.Bairro))
                .ForMember(to => to.Cidade, opt => opt.MapFrom(from => from.Endereco.Cidade))
                .ForMember(to => to.UF, opt => opt.MapFrom(from => from.Endereco.UF))
                .ForMember(to => to.CEP, opt => opt.MapFrom(from => from.Endereco.CEP));
        }
    }
}
