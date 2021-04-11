using System.Collections;
using System.Collections.Generic;
using MHRArmorBuilder.Interfaces;
using Prism.Events;

namespace MHRArmorBuilder.Core
{
    public class SearchStartEvent : PubSubEvent<IEnumerable<IConstraint>>
    {
    }
}