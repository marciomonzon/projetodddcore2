using AutoMapper;
using CursoCore.Application.Interfaces;
using CursoCore.Application.Services;
using CursoCore.Domain.Interfaces.Repository;
using CursoCore.Domain.Interfaces.Services;
using CursoCore.Domain.Services;
using CursoCore.Infrastructure.Data.Context;
using CursoCore.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCore.Ioc
{
    public class NativeInjectorMapping
    {
        /// <summary>
        /// Instanciando as Injções de Depencencia
        /// É um Container
        /// </summary>
        /// <param name="service"></param>
       /* public static void RegisterServices(IServiceCollection service)
        {
            #region instanciando o Mapper usado no ServiceCliente da Application
            service.AddSingleton(Mapper.Configuration);
            service.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            #endregion

            #region Camada Application
            service.AddScoped<IApplicationCliente, ApplicationCliente>();
            //service.AddScoped<IApplicationFornecedor, ApplicationFornecedores>();
            #endregion

            #region camada Domain - Services
            service.AddScoped<IServiceCliente, ServiceCliente>();
            service.AddScoped<IServiceFornecedor, ServiceFornecedor>();
            service.AddScoped<IServiceProduto, ServiceProduto>();
            service.AddScoped<IServiceItensPedidos, ServiceItensPedidos>();
            service.AddScoped<IServicePedidos, ServicePedidos>();
            #endregion

            #region camada Domain e Infra - Repositorios - Interfaces
            service.AddScoped<IRepositoryCliente, RepositoryCliente>();
            service.AddScoped<IRepositoryFornecedor, RepositoryFornecedor>();
            service.AddScoped<IRepositoryProduto, RepositoryProduto>();
            service.AddScoped<IRepositoryPedidos, RepositoryPedido>();
            #endregion

            #region Contexto no Infra
            service.AddScoped<ContextEFPedidos>();
            #endregion
        }*/
    }
}
