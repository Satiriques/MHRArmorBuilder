using System;
using System.Linq;
using System.Runtime.Serialization;
using MHRArmorBuilder.Interfaces;
using MHRArmorBuilder.Models;
using Prism.Commands;

namespace MHRArmorBuilder.ViewModels
{
    public class SkillConstraintViewModel : ConstraintMinMax
    {
        public SkillConstraintViewModel(SkillName skillName, DelegateCommand<IConstraint> deleteCommand)
        : base(deleteCommand)
        {
            SkillName = skillName;
            DisplayString = GetEnumMemberAttrValue(typeof(SkillName), skillName);

            Predicate = new Predicate<ArmorSet>(set =>
            {
                var values = set.ArmorPieces.SelectMany(x => x.Skills).Where(x => x.SkillName == SkillName).ToArray();

                if (!values.Any()) return false;

                var sum = values.Sum(x => x.Value);
                return (!Min.HasValue || sum >= Min) && (!Max.HasValue || sum <= Max);
            });
        }
        
        public SkillName SkillName { get; init; }
        public string DisplayString { get; init; }
        
        private string GetEnumMemberAttrValue(Type enumType, object enumVal)
        {
            var memInfo = enumType.GetMember(enumVal.ToString());
            var attr = memInfo[0].GetCustomAttributes(false).OfType<EnumMemberAttribute>().FirstOrDefault();
            return attr?.Value;
        }

        public override Predicate<ArmorSet> Predicate { get; }
    }
}