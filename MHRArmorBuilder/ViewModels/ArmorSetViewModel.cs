using System.Linq;
using MHRArmorBuilder.Models;

namespace MHRArmorBuilder.ViewModels
{
    public class ArmorSetViewModel
    {
        public ArmorSetViewModel(ArmorSet armorSet)
        {
            Head = armorSet.ArmorPieces[0];
            Torso = armorSet.ArmorPieces[1];
            Waist = armorSet.ArmorPieces[2];
            Arms = armorSet.ArmorPieces[3];
            Legs = armorSet.ArmorPieces[4];

            RarityMin = armorSet.ArmorPieces.Min(x => x.Rarity);
            RarityMax = armorSet.ArmorPieces.Max(x => x.Rarity);
        }

        public ArmorPieceModel Legs { get; }
        public ArmorPieceModel Arms { get; }
        public ArmorPieceModel Waist { get; }
        public ArmorPieceModel Torso { get; }
        public ArmorPieceModel Head { get; }
        public int RarityMin { get; }
        public int RarityMax { get; }
    }
}