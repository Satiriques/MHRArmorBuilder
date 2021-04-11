using System;
using MHRArmorBuilder.Core;
using MHRArmorBuilder.Interfaces;
using MHRArmorBuilder.Models;
using Prism.Commands;

namespace MHRArmorBuilder.ViewModels
{
    public abstract class ConstraintMinMax : BindableBase, IConstraint
    {
        public DelegateCommand<IConstraint> DeleteCommand { get; }
        private int? _max;
        private int? _min;

        public ConstraintMinMax(DelegateCommand<IConstraint> deleteCommand)
        {
            DeleteCommand = deleteCommand;
            RaisePropertyChanged(nameof(DeleteCommand));
        }

        public int? Max
        {
            get => _max;
            set
            {
                if (_max == value) return;
                _max = value;
                RaisePropertyChanged();
            }
        }

        public int? Min
        {
            get => _min;
            set
            {
                if (_min == value) return;
                _min = value;
                RaisePropertyChanged();
            }
        }

        public abstract Predicate<ArmorSet> Predicate { get; }
        public string DisplayString => "Rarity";
    }
}