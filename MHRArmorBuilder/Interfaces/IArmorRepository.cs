using System.Collections.Generic;
using MHRArmorBuilder.Models;

namespace MHRArmorBuilder.Interfaces
{
    public interface IArmorRepository
    {
        IEnumerable<ArmorPieceModel> Models { get; }
    }
}