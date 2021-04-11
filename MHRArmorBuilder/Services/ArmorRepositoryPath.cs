using MHRArmorBuilder.Interfaces;

namespace MHRArmorBuilder.Services
{
    public class ArmorRepositoryPath : IArmorRepositoryPath
    {
        public ArmorRepositoryPath()
        {
            Path = "Data/armordb.json";
        }

        public string Path { get; }
    }
}