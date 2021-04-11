using System.Runtime.Serialization;

namespace MHRArmorBuilder.Models
{
    public enum SkillName
    {
        [EnumMember(Value = "Divine Blessing")]
        DivineBlessing,

        [EnumMember(Value = "Wirebug Whisperer")]
        WirebugWhisperer,
        [EnumMember(Value = "Heroics")] Heroics,
        [EnumMember(Value = "Critical Eye")] CriticalEye,
        [EnumMember(Value = "Wall Runner")] WallRunner,
        [EnumMember(Value = "Resuscitate")] Resuscitate,

        [EnumMember(Value = "Hunger Resistance")]
        HungerResistance,
        [EnumMember(Value = "Botanist")] Botanist,
        [EnumMember(Value = "Geologist")] Geologist,
        [EnumMember(Value = "Recovery Up")] RecoveryUp,

        [EnumMember(Value = "Special Ammo Boost")]
        SpecialAmmoBoost,
        [EnumMember(Value = "Defense Boost")] DefenseBoost,

        [EnumMember(Value = "Peak Performance")]
        PeakPerformance,
        [EnumMember(Value = "Guard")] Guard,
        [EnumMember(Value = "Stamina Surge")] StaminaSurge,
        [EnumMember(Value = "Flinch Free")] FlinchFree,
        [EnumMember(Value = "Item Prolonger")] ItemProlonger,
        [EnumMember(Value = "Attack Boost")] AttackBoost,
        [EnumMember(Value = "Quick Sheath")] QuickSheath,

        [EnumMember(Value = "Stun Resistance")]
        StunResistance,
        [EnumMember(Value = "Handicraft")] Handicraft,
        [EnumMember(Value = "Dragon Attack")] DragonAttack,
        [EnumMember(Value = "Focus")] Focus,

        [EnumMember(Value = "Power Prolonger")]
        PowerProlonger,
        [EnumMember(Value = "Water Attack")] WaterAttack,

        [EnumMember(Value = "Speed Sharpening")]
        SpeedSharpening,

        [EnumMember(Value = "Protective Polish")]
        ProtectivePolish,
        [EnumMember(Value = "Windproof")] Windproof,
        [EnumMember(Value = "Thunder Attack")] ThunderAttack,

        [EnumMember(Value = "Paralysis Resistance")]
        ParalysisResistance,
        [EnumMember(Value = "Recovery Speed")] RecoverySpeed,

        [EnumMember(Value = "Sleep Resistance")]
        SleepResistance,
        [EnumMember(Value = "Leap of Faith")] LeapofFaith,
        [EnumMember(Value = "Speed Eating")] SpeedEating,
        [EnumMember(Value = "Bubbly Dance")] BubblyDance,

        [EnumMember(Value = "Dragon Resistance")]
        DragonResistance,
        [EnumMember(Value = "Rapid Morph")] RapidMorph,
        [EnumMember(Value = "Maximum Might")] MaximumMight,
        [EnumMember(Value = "Fortify")] Fortify,

        [EnumMember(Value = "Blast Resistance")]
        BlastResistance,
        [EnumMember(Value = "Reload Speed")] ReloadSpeed,
        [EnumMember(Value = "Fire Attack")] FireAttack,
        [EnumMember(Value = "Recoil Down")] RecoilDown,

        [EnumMember(Value = "Critical Element")]
        CriticalElement,
        [EnumMember(Value = "Evade Window")] EvadeWindow,
        [EnumMember(Value = "Ammo Up")] AmmoUp,
        [EnumMember(Value = "Steadiness")] Steadiness,

        [EnumMember(Value = "Normal/Rapid Up")]
        NormalRapidUp,
        [EnumMember(Value = "Mushroomancer")] Mushroomancer,

        [EnumMember(Value = "Poison Resistance")]
        PoisonResistance,

        [EnumMember(Value = "Thunder Resistance")]
        ThunderResistance,
        [EnumMember(Value = "Capture Master")] CaptureMaster,
        [EnumMember(Value = "Poison Attack")] PoisonAttack,
        [EnumMember(Value = "Latent Power")] LatentPower,

        [EnumMember(Value = "Weakness Exploit")]
        WeaknessExploit,
        [EnumMember(Value = "Mind's Eye")] MindsEye,
        [EnumMember(Value = "Free Meal")] FreeMeal,
        [EnumMember(Value = "Wide-Range")] WideRange,
        [EnumMember(Value = "Good Luck")] GoodLuck,
        [EnumMember(Value = "Razor Sharp")] RazorSharp,
        [EnumMember(Value = "Spare Shot")] SpareShot,
        [EnumMember(Value = "Agitator")] Agitator,

        [EnumMember(Value = "Water Resistance")]
        WaterResistance,
        [EnumMember(Value = "Aim Booster")] AimBooster,
        [EnumMember(Value = "Spread Up")] SpreadUp,
        [EnumMember(Value = "Pierce Up")] PierceUp,
        [EnumMember(Value = "Blast Attack")] BlastAttack,
        [EnumMember(Value = "Partbreaker")] Partbreaker,
        [EnumMember(Value = "Evade Extender")] EvadeExtender,
        [EnumMember(Value = "Sleep Attack")] SleepAttack,
        [EnumMember(Value = "Bombardier")] Bombardier,
        [EnumMember(Value = "Constitution")] Constitution,
        [EnumMember(Value = "Critical Draw")] CriticalDraw,
        [EnumMember(Value = "Punishing Draw")] PunishingDraw,
        [EnumMember(Value = "Resentment")] Resentment,
        [EnumMember(Value = "Wind Alignment")] WindAlignment,
        [EnumMember(Value = "Slugger")] Slugger,
        [EnumMember(Value = "Guard Up")] GuardUp,

        [EnumMember(Value = "Thunder Alignment")]
        ThunderAlignment,

        [EnumMember(Value = "Offensive Guard")]
        OffensiveGuard,
        [EnumMember(Value = "Artillery")] Artillery,

        [EnumMember(Value = "Marathon Runner")]
        MarathonRunner,
        [EnumMember(Value = "Diversion")] Diversion,

        [EnumMember(Value = "Tremor Resistance")]
        TremorResistance,
        [EnumMember(Value = "Master Mounter")] MasterMounter,

        [EnumMember(Value = "Paralysis Attack")]
        ParalysisAttack,
        [EnumMember(Value = "Bludgeoner")] Bludgeoner,
        [EnumMember(Value = "Critical Boost")] CriticalBoost,

        [EnumMember(Value = "Fire Resistance")]
        FireResistance,
        [EnumMember(Value = "Rapid Fire Up")] RapidFireUp,
        [EnumMember(Value = "Ice Attack")] IceAttack,
        [EnumMember(Value = "Counterstrike")] Counterstrike,
        [EnumMember(Value = "Jump Master")] JumpMaster,

        [EnumMember(Value = "Affinity Sliding")]
        AffinitySliding,

        [EnumMember(Value = "Blight Resistance")]
        BlightResistance,
        [EnumMember(Value = "Earplugs")] Earplugs,
        [EnumMember(Value = "Load Shells")] LoadShells,
        [EnumMember(Value = "Horn Maestro")] HornMaestro,
        [EnumMember(Value = "Stamina Thief")] StaminaThief,

        [EnumMember(Value = "Bow Charge Plus")]
        BowChargePlus,
        [EnumMember(Value = "Hellfire Cloak")] HellfireCloak,

        [EnumMember(Value = "Muck Resistance")]
        MuckResistance
    }
}