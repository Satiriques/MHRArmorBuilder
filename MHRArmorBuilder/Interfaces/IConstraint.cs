using System;
using MHRArmorBuilder.Models;

namespace MHRArmorBuilder.Interfaces
{
    public interface IConstraint
    {
        Predicate<ArmorSet> Predicate { get; }
        string DisplayString { get; }
    }
}