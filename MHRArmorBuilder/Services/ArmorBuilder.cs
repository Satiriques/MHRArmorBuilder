using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MHRArmorBuilder.Core;
using MHRArmorBuilder.Interfaces;
using MHRArmorBuilder.Models;
using MHRArmorBuilder.ViewModels;

namespace MHRArmorBuilder.Services
{
    public class ArmorBuilder : IArmorBuilder
    {
        private readonly IArmorRepository _armorRepository;
        private readonly Random _random = new Random();

        public ArmorBuilder(IArmorRepository armorRepository)
        {
            _armorRepository = armorRepository;
        }

        public async IAsyncEnumerable<ArmorSet> GenerateArmorSets(IEnumerable<IConstraint> constraints)
        {
            var combinations = GeneratePermutations(constraints);

            var chunks = combinations.Chunk(combinations.Count() / 8);
            var tasks = new Task<IEnumerable<ArmorSet>>[8];

            for (var i=0;i<8;i++)
            {
                tasks[i] = GetValidPermutations(chunks.ElementAt(i), constraints);
            }

            foreach (var task in tasks)
            {
                var result = await task;
                
                foreach (var item in result)
                {
                    yield return item;
                }
               
            }
        }

        private async Task<IEnumerable<ArmorSet>> GetValidPermutations(IEnumerable<ArmorSet> armorSets,
            IEnumerable<IConstraint> constraints)
        {
            IEnumerable<ArmorSet> validArmorSet = null;
            await Task.Run(() => validArmorSet = armorSets.Where(armorSet => constraints.All(x => x.Predicate(armorSet))));
            return validArmorSet;
        }

        // private async IAsyncEnumerable<ArmorSet> GetValidPermutations(IEnumerable<ArmorSet> armorSets, IEnumerable<IConstraint> constraints)
        // {
        //    
        //     await Task.Run(() =>
        //     {
        //         List<ArmorSet> sets = new List<ArmorSet>();
        //         foreach (var armorSet in armorSets)
        //         {
        //             if (constraints.All(x => x.Predicate(armorSet)))
        //             {
        //                 sets.Add(armorSet);
        //             }
        //         }
        //
        //         return sets;
        //     });
        // }

        private IEnumerable<ArmorSet> GeneratePermutations(IEnumerable<IConstraint> constraints)
        {
            var skills = constraints.OfType<SkillConstraintViewModel>().Select(x => x.SkillName);

            var helms = GetPieceTypes(skills, Slot.Head);
            var torsos = GetPieceTypes(skills, Slot.Torso);
            var arms = GetPieceTypes(skills, Slot.Arms);
            var waists = GetPieceTypes(skills, Slot.Waist);
            var legs = GetPieceTypes(skills, Slot.Leg);

            var combinations = from h in helms
                from t in torsos
                from a in arms
                from w in waists
                from l in legs
                select new ArmorSet( new ArmorPieceModel[] {h, t, a, w, l});

            return combinations;
        }

        private IEnumerable<ArmorPieceModel> GetPieceTypes(IEnumerable<SkillName> skills, Slot slot)
        {
            return _armorRepository.Models
                .Where(x => x.Slot == slot && skills.Intersect(x.Skills.Select(y => y.SkillName)).Any())
                .Union(new[] {new EmptyArmorPieceModel()});
        }

        // public async IAsyncEnumerable<ArmorSet> GenerateArmorSets(IEnumerable<IConstraint> constraints)
        // {
        //     var tasks = new Task<ArmorSet>[100];
        //
        //     for (var i = 0; i < 100; i++)
        //     {
        //         tasks[i] = GetArmorSetTest();
        //     }
        //
        //     foreach (var task in tasks)
        //     {
        //         yield return await task;
        //     }
        // }
        //
        // private async Task<ArmorSet> GetArmorSetTest()
        // {
        //     await Task.Delay(_random.Next(1000, 5000));
        //     return new ArmorSet();
        // }
    }
}