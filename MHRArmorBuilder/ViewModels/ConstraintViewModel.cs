using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows.Input;
using MHRArmorBuilder.Core;
using MHRArmorBuilder.Interfaces;
using MHRArmorBuilder.Models;
using Prism.Commands;
using Prism.Events;

namespace MHRArmorBuilder.ViewModels
{
    class ConstraintViewModel : BindableBase
    {
        private readonly IEventAggregator _eventAggregator;
        private IConstraint _selectedConstraint;
        private int _constraintIndex;

        public ConstraintViewModel(IArmorRepository armorRepository, IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            SearchCommand = new DelegateCommand(SearchExecute);
            var delegateCommand = new DelegateCommand<IConstraint>(DeleteConstraint);
            
            var values =Enum.GetValues<SkillName>();
            foreach (var value in values)
            {
                Constraints.Add(new SkillConstraintViewModel(value, delegateCommand));
            }
            
            Constraints.Add(new RarityConstraintViewModel(delegateCommand));
        }

        private void DeleteConstraint(IConstraint constraint)
        {
            AddedConstraints.Remove(constraint);
            Constraints.Add(constraint);
        }

        private void SearchExecute()
        {
            _eventAggregator.GetEvent<SearchStartEvent>().Publish(AddedConstraints);
        }

        public ObservableCollection<IConstraint> Constraints { get; } = new();
        public ObservableCollection<IConstraint> AddedConstraints { get; } = new();
        public ICommand SearchCommand { get; }
        
        public IConstraint SelectedConstraint
        {
            get => _selectedConstraint;
            set
            {
                if (_selectedConstraint == value) return;
                _selectedConstraint = value;
                if (value != null)
                {
                    AddedConstraints.Add(value);
                    Constraints.Remove(value);
                    // _selectedConstraint = null;
                    // ConstraintIndex = -1;
                }
                RaisePropertyChanged();
            }
        }

        public int ConstraintIndex
        {
            get => _constraintIndex;
            set
            {
                if (_constraintIndex == value) return;
                _constraintIndex = value;
                RaisePropertyChanged();
            }
        }
    }
}
