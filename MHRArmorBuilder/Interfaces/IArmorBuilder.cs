using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using MHRArmorBuilder.Models;

namespace MHRArmorBuilder.Interfaces
{
    public interface IArmorBuilder
    {
        IAsyncEnumerable<ArmorSet> GenerateArmorSets(IEnumerable<IConstraint> constraints);
    }
}