using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.Services;
using ExemploSeguros.Data.Context;
using ExemploSeguros.Data.Repository;
using ExemploSeguros.Data.UnitOfWork;
using ExemploSeguros.Domain.Business;
using ExemploSeguros.Domain.Commands.CommandHandlers;
using ExemploSeguros.Domain.Commands.CotacaoCommand;
using ExemploSeguros.Domain.Core.Interfaces;
using ExemploSeguros.Domain.Core.Notifications;
using ExemploSeguros.Domain.Events;
using ExemploSeguros.Domain.Events.EventsHandlers;
using ExemploSeguros.Domain.Interfaces.Business;
using ExemploSeguros.Domain.Interfaces.Repository.ClienteRepo;
using ExemploSeguros.Domain.Interfaces.Repository.CoberturasRepo;
using ExemploSeguros.Domain.Interfaces.Repository.CotacaoRepo;
using ExemploSeguros.Domain.Interfaces.Repository.ItemRepo;
using ExemploSeguros.Domain.Interfaces.Repository.PerfilRepo;
using ExemploSeguros.Domain.Interfaces.Repository.QuestionarioRepo;
using ExemploSeguros.Domain.Interfaces.Uow;
using ExemploSeguros.Domain.Interfaces.User;
using ExemploSeguros.Infra.CrossCutting.Bus;
using ExemploSeguros.Infra.CrossCutting.Identity.Models;
using ExemploSeguros.Infra.CrossCutting.Identity.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ExemploSeguros.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASPNET
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Application
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));

            services.AddScoped<ICotacaoAppService, CotacaoAppService>();
            services.AddScoped<ITipoCalculoAppService, TipoCalculoAppService>();
            services.AddScoped<ITipoSeguroAppService, TipoSeguroAppService>();
            services.AddScoped<IClienteAppService, ClienteAppService>();
            services.AddScoped<IProfissaoAppService, ProfissaoAppService>();
            services.AddScoped<IPaisResidenciaAppService, PaisResidenciaAppService>();
            services.AddScoped<IModeloAppService, ModeloAppService>();
            services.AddScoped<IMarcaAppService, MarcaAppService>();
            services.AddScoped<IItemAppService, ItemAppService>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IUsoAppService, UsoAppService>();
            services.AddScoped<IImpostoAppService, ImpostoAppService>();
            services.AddScoped<IQuestionarioAppService, QuestionarioAppService>();
            services.AddScoped<IPerfilAppService, PerfilAppService>();
            services.AddScoped<ICoberturasAppService, CoberturasAppService>();

            // Domain - Commands
            services.AddScoped<IHandler<RegistrarCotacaoCommand>, CotacaoCommandHandler>();
            services.AddScoped<IHandler<AtualizarCotacaoCommand>, CotacaoCommandHandler>();
            services.AddScoped<IHandler<RemoverCotacaoCommand>, CotacaoCommandHandler>();

            // Domain - Cotacao
            services.AddScoped<IDomainNotificationHandler<DomainNotification>, DomainNotificationHandler>();
            services.AddScoped<IHandler<CotacaoRegistradoEvent>, CotacaoEventHandler>();
            services.AddScoped<IHandler<CotacaoAtualizadoEvent>, CotacaoEventHandler>();
            services.AddScoped<IHandler<CotacaoRemoverEvent>, CotacaoEventHandler>();

            // Business - Cotacao
            services.AddScoped<ICalculoService, CalculoService>();

            // Infra - Data
            services.AddScoped<ICotacaoRepository, CotacaoRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IQuestionarioRepository, QuestionarioRepository>();
            services.AddScoped<IPerfilRepository, PerfilRepository>();
            services.AddScoped<ICoberturasRepository, CoberturasRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ExemploSegurosContext>();

            // Infra - Bus
            services.AddScoped<IBus, InMemoryBus>();

            // Infra - Identity
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}