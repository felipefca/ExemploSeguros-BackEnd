using AutoMapper;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Models.ClienteRoot;
using ExemploSeguros.Domain.Models.CoberturasRoot;
using ExemploSeguros.Domain.Models.CotacaoRoot;
using ExemploSeguros.Domain.Models.ItemRoot;
using ExemploSeguros.Domain.Models.PerfilRoot;
using ExemploSeguros.Domain.Models.QuestionarioRoot;

namespace ExemploSeguros.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cotacao, CotacaoViewModel>();
            CreateMap<TipoCalculo, TipoCalculoViewModel>();
            CreateMap<TipoSeguro, TipoSeguroViewModel>();
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<PaisResidencia, PaisResidenciaViewModel>();
            CreateMap<Profissao, ProfissaoViewModel>();
            CreateMap<Item, ItemViewModel>();
            CreateMap<Marca, MarcaViewModel>();
            CreateMap<Modelo, ModeloViewModel>();
            CreateMap<Uso, UsoViewModel>();
            CreateMap<Imposto, ImpostoViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
            CreateMap<Questionario, QuestionarioViewModel>();
            CreateMap<AntiFurto, AntiFurtoViewModel>();
            CreateMap<GararemFaculdade, GararemFaculdadeViewModel>();
            CreateMap<GararemResidencia, GararemResidenciaViewModel>();
            CreateMap<GararemTrabalho, GararemTrabalhoViewModel>();
            CreateMap<PropriedadeRastreador, PropriedadeRastreadorViewModel>();
            CreateMap<Rastreador, RastreadorViewModel>();
            CreateMap<RelacaoSegurado, RelacaoSeguradoViewModel>();
            CreateMap<Perfil, PerfilViewModel>();
            CreateMap<DistanciaTrabalho, DistanciaTrabalhoViewModel>();
            CreateMap<EstadoCivil, EstadoCivilViewModel>();
            CreateMap<QuantidadeVeiculos, QuantidadeVeiculosViewModel>();
            CreateMap<Sexo, SexoViewModel>();
            CreateMap<TempoHabilitacao, TempoHabilitacaoViewModel>();
            CreateMap<TipoResidencia, TipoResidenciaViewModel>();
            CreateMap<Coberturas, CoberturasViewModel>();
            CreateMap<CoberturasProduto, CoberturasViewModel>();
            CreateMap<CoberturasItem, CoberturaItemViewModel>();
        }
    }
}