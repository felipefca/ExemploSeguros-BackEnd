using System;
using System.Collections.Generic;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Commands.ClienteCommand;

namespace ExemploSeguros.Application.AutoMapper
{
    public class SelectedCoberturaViewModelToCoberturaItem
    {
        public List<IncluirCoberturaEventoCommand> Map(List<CoberturaItemViewModel> viewModel, Guid itemId)
        {
            var listCoberturasItem = new List<IncluirCoberturaEventoCommand>();

            foreach (var elemento in viewModel)
            {
                var cobertura = new IncluirCoberturaEventoCommand(elemento.Id, itemId, elemento.CoberturaId, elemento.Valor);
                listCoberturasItem.Add(cobertura);
            }

            return listCoberturasItem;
        }
    }
}