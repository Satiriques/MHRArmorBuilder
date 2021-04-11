using MHRArmorBuilder.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MHRArmorBuilder.Models
{
    public enum Slot
    {
        Head,
        Torso,
        Leg,
        Waist,
        Arms
    }
    
    public class ArmorPieceModel
    {
        public string PartName { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Slot Slot { get; init; }
        public int Rarity { get; init; }
        public int Defense { get; init; }
        public int FireRes { get; init; }
        public int WatRes { get; init; }
        public int IceRes { get; init; }
        public int ThrRes { get; init; }
        public int DrgRes { get; init; }
        public string JewelSlots { get; init; }
        public ValueSet<Skill> Skills { get; } = new ValueSet<Skill>();
    }

    public class Skill
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public SkillName SkillName { get; init; }
        public int Value { get; init; }
    }
}