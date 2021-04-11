using System.Linq;

namespace MHRArmorBuilder.Models
{
    public class ArmorSet
    {
        public ArmorSet(ArmorPieceModel[] armorPieces)
        {
            ArmorPieces = armorPieces;
        }
        
        public ArmorPieceModel[] ArmorPieces { get; }
    }
}