using System;
using System.Linq;
using MHRArmorBuilder.Interfaces;
using MHRArmorBuilder.Models;
using Prism.Commands;

namespace MHRArmorBuilder.ViewModels
{
    public class RarityConstraintViewModel : ConstraintMinMax
    {
        public RarityConstraintViewModel(DelegateCommand<IConstraint> deleteCommand)
            : base(deleteCommand)
        {
            Predicate = new Predicate<ArmorSet>(set =>
            {
                var minRarity = set.ArmorPieces.Min(x => x.Rarity);
                var maxRarity = set.ArmorPieces.Max(x => x.Rarity);
                return (!Min.HasValue || minRarity >= Min) && (!Max.HasValue || maxRarity <= Max);
            });
        }

        public override Predicate<ArmorSet> Predicate { get; }
    }
}