using System.Collections.Generic;
using System.Collections.ObjectModel;
using MHRArmorBuilder.Core;
using MHRArmorBuilder.Interfaces;
using MHRArmorBuilder.Models;
using Prism.Events;

namespace MHRArmorBuilder.ViewModels
{
    class ResultViewModel : BindableBase
    {
        private readonly IArmorBuilder _armorBuilder;

        public ResultViewModel(IEventAggregator eventAggregator, IArmorBuilder armorBuilder)
        {
            _armorBuilder = armorBuilder;
            eventAggregator.GetEvent<SearchStartEvent>().Subscribe(OnSearchStart);
        }

        public ObservableCollection<ArmorSetViewModel> ArmorSets { get; } = new();

        private async void OnSearchStart(IEnumerable<IConstraint> constraints)
        {
            ArmorSets.Clear();
            await foreach (var armor in _armorBuilder.GenerateArmorSets(constraints))
            {
                ArmorSets.Add(new ArmorSetViewModel(armor));
            }
        }
    }
}
