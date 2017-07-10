using System;
using System.Collections.Generic;
using AutoMapper;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Commands.ClienteCommand;
using ExemploSeguros.Domain.Commands.CotacaoCommand;

namespace ExemploSeguros.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CotacaoViewModel, RegistrarCotacaoCommand>()
                .ConstructUsing(c => new RegistrarCotacaoCommand(c.NumCotacao, c.DataCalculo, c.DataCadastro,
                    c.DataVigenciaInicial, c.DataVigenciaFinal, c.UserId, c.PremioTotal, c.TipoCalculoId,
                    c.TipoSeguroId,
                    new IncluirClienteEventoCommand(c.Cliente.Id, c.Cliente.Nome, c.Cliente.SobreNome, c.Cliente.Cpf,
                        c.Cliente.Telefone, c.Cliente.Rg, c.Cliente.Email, c.Cliente.DataNascimento,
                        c.Cliente.ProfissaoId, c.Cliente.PaisResidenciaId,
                        new IncluirEnderecoEventoCommand(c.Cliente.Endereco.Id, c.Cliente.Endereco.Logradouro,
                            c.Cliente.Endereco.Numero, c.Cliente.Endereco.Complemento, c.Cliente.Endereco.Bairro,
                            c.Cliente.Endereco.Cep, c.Cliente.Endereco.Cidade, c.Cliente.Endereco.Estado,
                            c.Cliente.Endereco.ClienteId), c.Cliente.CotacaoId),
                    new IncluirItemEventoCommand(c.Item.Id, c.Item.ProdutoId, c.Item.ModeloId, c.Item.NumChassi,
                        c.Item.FlagRemarcado, c.Item.DataSaida, c.Item.Odometro, c.Item.UsoId, c.Item.ImpostoId,
                        c.Item.CotacaoId, new SelectedCoberturaViewModelToCoberturaItem().Map(c.Item.ListCoberturasItem, c.Item.Id)), 
                    new IncluirQuestionarioEventoCommand(c.Questionario.Id, c.Questionario.CepPernoite,
                        c.Questionario.FlagBlindado, c.Questionario.FlagAdaptadoDeficiente, c.Questionario.FlagKitGas,
                        c.Questionario.FlagAlienado, c.Questionario.FlagAntiFurto, c.Questionario.FlagGararem,
                        c.Questionario.RastreadorId, c.Questionario.AntiFurtoId, c.Questionario.RelacaoSeguradoId,
                        c.Questionario.GararemResidenciaId, c.Questionario.GararemTrabalhoId,
                        c.Questionario.GaragemFaculdadeId, c.Questionario.PropriedadeRastreadorId,
                        c.Questionario.CotacaoId),
                    new IncluirPerfilEventoCommand(c.Perfil.Id, c.Perfil.CpfPrincipalCondutor,
                        c.Perfil.NomePrincipalCondutor, c.Perfil.DataNascPrincipalCondutor,
                        c.Perfil.FlagResideMenorIdade, c.Perfil.FlagSegPrincipalCondutor, c.Perfil.FlagPontosCarteira,
                        c.Perfil.EstadoCivilId, c.Perfil.TipoResidenciaId, c.Perfil.SexoId, c.Perfil.TempoHabilitacaoId,
                        c.Perfil.DistanciaTrabalhoId, c.Perfil.QuantidadeVeiculoId, c.Perfil.CotacaoId)));


            CreateMap<CotacaoViewModel, AtualizarCotacaoCommand>()
                .ConstructUsing(c => new AtualizarCotacaoCommand(c.Id, c.NumCotacao, c.DataCalculo, c.DataCadastro, c.DataVigenciaInicial, c.DataVigenciaFinal, c.UserId, c.PremioTotal, c.TipoCalculoId, c.TipoSeguroId));

            CreateMap<CotacaoViewModel, RemoverCotacaoCommand>()
                .ConstructUsing(c => new RemoverCotacaoCommand(c.Id));

            CreateMap<ClienteViewModel, IncluirClienteEventoCommand>()
                .ConstructUsing(c => new IncluirClienteEventoCommand(Guid.NewGuid(), c.Nome, c.SobreNome, c.Cpf, c.Telefone, c.Rg, c.Email, c.DataNascimento, c.ProfissaoId, c.PaisResidenciaId,
                new IncluirEnderecoEventoCommand(c.Endereco.Id, c.Endereco.Logradouro, c.Endereco.Numero, c.Endereco.Complemento, c.Endereco.Bairro, c.Endereco.Cep, c.Endereco.Cidade,
                c.Endereco.Estado, c.Endereco.ClienteId), c.CotacaoId));

            CreateMap<EnderecoViewModel, IncluirEnderecoEventoCommand>()
                .ConstructUsing(c => new IncluirEnderecoEventoCommand(Guid.NewGuid(), c.Logradouro, c.Numero, c.Complemento, c.Bairro, c.Cep, c.Cidade, c.Estado, c.ClienteId));

            CreateMap<ItemViewModel, IncluirItemEventoCommand>()
                .ConstructUsing(i => new IncluirItemEventoCommand(Guid.NewGuid(), i.ProdutoId, i.ModeloId, i.NumChassi,
                    i.FlagRemarcado, i.DataSaida, i.Odometro, i.UsoId, i.ImpostoId, i.CotacaoId,
                    new List<IncluirCoberturaEventoCommand>()));

            CreateMap<QuestionarioViewModel, IncluirQuestionarioEventoCommand>()
                .ConstructUsing(
                    q =>
                        new IncluirQuestionarioEventoCommand(Guid.NewGuid(), q.CepPernoite, q.FlagBlindado,
                            q.FlagAdaptadoDeficiente, q.FlagKitGas, q.FlagAlienado, q.FlagAntiFurto, q.FlagGararem,
                            q.RastreadorId, q.AntiFurtoId, q.RelacaoSeguradoId, q.GararemResidenciaId,
                            q.GararemTrabalhoId, q.GaragemFaculdadeId, q.PropriedadeRastreadorId, q.CotacaoId));

            CreateMap<PerfilViewModel, IncluirPerfilEventoCommand>()
                .ConstructUsing(
                    p =>
                        new IncluirPerfilEventoCommand(Guid.NewGuid(), p.CpfPrincipalCondutor, p.NomePrincipalCondutor,
                            p.DataNascPrincipalCondutor, p.FlagResideMenorIdade, p.FlagSegPrincipalCondutor,
                            p.FlagPontosCarteira, p.EstadoCivilId, p.TipoResidenciaId, p.SexoId, p.TempoHabilitacaoId,
                            p.DistanciaTrabalhoId, p.QuantidadeVeiculoId, p.CotacaoId));

            CreateMap<CoberturaItemViewModel, IncluirCoberturaEventoCommand>()
                .ConstructUsing(
                    c => new IncluirCoberturaEventoCommand(Guid.NewGuid(), c.ItemId, c.CoberturaId, c.Valor));

        }
    }
}