using System.Collections.Generic;
using System.IO;
using System.Linq;
using Autofac;
using MHRArmorBuilder.Interfaces;
using MHRArmorBuilder.Models;
using Newtonsoft.Json;

namespace MHRArmorBuilder.Services
{
    public class ArmorRepository : IArmorRepository, IStartable
    {
        private readonly string _path;
        public IEnumerable<ArmorPieceModel> Models { get; private set; }

        public ArmorRepository(IArmorRepositoryPath armorRepositoryPath)
        {
            _path = armorRepositoryPath.Path;
        }

        public void Start()
        {
            var text = File.ReadAllText(_path);
            Models = JsonConvert.DeserializeObject<IEnumerable<ArmorPieceModel>>(text);
        }
    }
}