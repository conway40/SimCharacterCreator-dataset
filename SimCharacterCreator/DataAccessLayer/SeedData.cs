using SimCharacterCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCharacterCreator.DataAccessLayer
{
    public static class SeedData
    {
        public static List<Sim> GenerateListOfCharacters()
        {
            List<Sim> sims = new List<Sim>()
            {
                new Sim()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Pancakes",
                    Age = Sim.AgeCategory.YoungAdult,
                    Gender = Sim.GenderType.Male,
                    Trait1 = Sim.PersonalityTrait.Slob,
                    Trait2 = Sim.PersonalityTrait.Gloomy,
                    Trait3 = Sim.PersonalityTrait.Loner,
                    Aspiration = Sim.AspirationType.MasterChef,
                    ImageFileName = "BobPancakes.png"
                },
                new Sim()
                {
                    Id = 2,
                    FirstName = "Eliza",
                    LastName = "Pancakes",
                    Age = Sim.AgeCategory.YoungAdult,
                    Gender = Sim.GenderType.Female,
                    Trait1 = Sim.PersonalityTrait.Materialistic,
                    Trait2 = Sim.PersonalityTrait.Neat,
                    Trait3 = Sim.PersonalityTrait.Perfectionist,
                    Aspiration = Sim.AspirationType.MansionBaron,
                    ImageFileName = "ElizaPancakes.png"
                },
                new Sim()
                {
                    Id = 3,
                    FirstName = "Mortimer",
                    LastName = "Goth",
                    Age = Sim.AgeCategory.Adult,
                    Gender = Sim.GenderType.Male,
                    Trait1 = Sim.PersonalityTrait.Bookworm,
                    Trait2 = Sim.PersonalityTrait.Outgoing,
                    Trait3 = Sim.PersonalityTrait.Creative,
                    Aspiration = Sim.AspirationType.RenaissanceSim,
                    ImageFileName = "MortimerGoth.png"
                },
                new Sim()
                {
                    Id = 4,
                    FirstName = "Bella",
                    LastName = "Goth",
                    Age = Sim.AgeCategory.YoungAdult,
                    Gender = Sim.GenderType.Female,
                    Trait1 = Sim.PersonalityTrait.Good,
                    Trait2 = Sim.PersonalityTrait.FamilyOriented,
                    Trait3 = Sim.PersonalityTrait.Romantic,
                    Aspiration = Sim.AspirationType.PartyAnimal,
                    ImageFileName = "BellaGoth.png"
                },
                new Sim()
                {
                    Id = 5,
                    FirstName = "Katrina",
                    LastName = "Caliente",
                    Age = Sim.AgeCategory.Adult,
                    Gender = Sim.GenderType.Female,
                    Trait1 = Sim.PersonalityTrait.HotHeaded,
                    Trait2 = Sim.PersonalityTrait.FamilyOriented,
                    Trait3 = Sim.PersonalityTrait.Romantic,
                    Aspiration = Sim.AspirationType.Soulmate,
                    ImageFileName = "KatrinaCaliente.png"
                },
                new Sim()
                {
                    Id = 6,
                    FirstName = "Nina",
                    LastName = "Caliente",
                    Age = Sim.AgeCategory.YoungAdult,
                    Gender = Sim.GenderType.Female,
                    Trait1 = Sim.PersonalityTrait.Lazy,
                    Trait2 = Sim.PersonalityTrait.HotHeaded,
                    Trait3 = Sim.PersonalityTrait.Romantic,
                    Aspiration = Sim.AspirationType.ChiefOfMischief,
                    ImageFileName = "NinaCaliente.png"
                },
                new Sim()
                {
                    Id = 7,
                    FirstName = "Dina",
                    LastName = "Caliente",
                    Age = Sim.AgeCategory.YoungAdult,
                    Gender = Sim.GenderType.Female,
                    Trait1 = Sim.PersonalityTrait.Active,
                    Trait2 = Sim.PersonalityTrait.Ambitious,
                    Trait3 = Sim.PersonalityTrait.Romantic,
                    Aspiration = Sim.AspirationType.MasterMixologist,
                    ImageFileName = "DinaCaliente.png"
                },
                new Sim()
                {
                    Id = 8,
                    FirstName = "Don",
                    LastName = "Lothario",
                    Age = Sim.AgeCategory.YoungAdult,
                    Gender = Sim.GenderType.Male,
                    Trait1 = Sim.PersonalityTrait.Active,
                    Trait2 = Sim.PersonalityTrait.Noncommittal,
                    Trait3 = Sim.PersonalityTrait.Romantic,
                    Aspiration = Sim.AspirationType.SerialRomantic,
                    ImageFileName = "DonLothario.png"
                },
                new Sim()
                {
                    Id = 9,
                    FirstName = "Nancy",
                    LastName = "Landgraab",
                    Age = Sim.AgeCategory.Adult,
                    Gender = Sim.GenderType.Female,
                    Trait1 = Sim.PersonalityTrait.Ambitious,
                    Trait2 = Sim.PersonalityTrait.Snob,
                    Trait3 = Sim.PersonalityTrait.Materialistic,
                    Aspiration = Sim.AspirationType.FabulouslyWeathly,
                    ImageFileName = "NancyLandgraab.png"
                },
                new Sim()
                {
                    Id = 10,
                    FirstName = "Geoffrey",
                    LastName = "Landgraab",
                    Age = Sim.AgeCategory.Adult,
                    Gender = Sim.GenderType.Male,
                    Trait1 = Sim.PersonalityTrait.FamilyOriented,
                    Trait2 = Sim.PersonalityTrait.Outgoing,
                    Trait3 = Sim.PersonalityTrait.Good,
                    Aspiration = Sim.AspirationType.SuccessfulLineage,
                    ImageFileName = "GeoffreyLandgraab.png"
                },
                new Sim()
                {
                    Id = 11,
                    FirstName = "Malcolm",
                    LastName = "Landgraab",
                    Age = Sim.AgeCategory.Teen,
                    Gender = Sim.GenderType.Male,
                    Trait1 = Sim.PersonalityTrait.Snob,
                    Trait2 = Sim.PersonalityTrait.Evil,
                    Trait3 = Sim.PersonalityTrait.Kleptomaniac,
                    Aspiration = Sim.AspirationType.PublicEnemy,
                    ImageFileName = "MalcolmLandgraab.png"
                },
                new Sim()
                {
                    Id = 12,
                    FirstName = "Angela",
                    LastName = "Pleasant",
                    Age = Sim.AgeCategory.Teen,
                    Gender = Sim.GenderType.Female,
                    Trait1 = Sim.PersonalityTrait.Foodie,
                    Trait2 = Sim.PersonalityTrait.Neat,
                    Trait3 = Sim.PersonalityTrait.Vegetarian,
                    Aspiration = Sim.AspirationType.BigHappyFamily,
                    ImageFileName = "AngelaPleasant.png"
                },
                new Sim()
                {
                    Id = 13,
                    FirstName = "Lilith",
                    LastName = "Pleasant",
                    Age = Sim.AgeCategory.Teen,
                    Gender = Sim.GenderType.Female,
                    Trait1 = Sim.PersonalityTrait.Loner,
                    Trait2 = Sim.PersonalityTrait.Kleptomaniac,
                    Trait3 = Sim.PersonalityTrait.Erratic,
                    Aspiration = Sim.AspirationType.ChiefOfMischief,
                    ImageFileName = "LilithPleasant.png"
                },
                new Sim()
                {
                    Id = 14,
                    FirstName = "Vivian",
                    LastName = "Lewis",
                    Age = Sim.AgeCategory.Elder,
                    Gender = Sim.GenderType.Female,
                    Trait1 = Sim.PersonalityTrait.Foodie,
                    Trait2 = Sim.PersonalityTrait.FamilyOriented,
                    Trait3 = Sim.PersonalityTrait.Cheerful,
                    Aspiration = Sim.AspirationType.BigHappyFamily,
                    ImageFileName = "VivianLewis.png"
                },
                new Sim()
                {
                    Id = 15,
                    FirstName = "Dennis",
                    LastName = "Kim",
                    Age = Sim.AgeCategory.Elder,
                    Gender = Sim.GenderType.Male,
                    Trait1 = Sim.PersonalityTrait.LovesOutdoors,
                    Trait2 = Sim.PersonalityTrait.Neat,
                    Trait3 = Sim.PersonalityTrait.Perfectionist,
                    Aspiration = Sim.AspirationType.SuccessfulLineage,
                    ImageFileName = "DennisKim.png"
                },
                new Sim()
                {
                    Id = 16,
                    FirstName = "Eric",
                    LastName = "Lewis",
                    Age = Sim.AgeCategory.YoungAdult,
                    Gender = Sim.GenderType.Male,
                    Trait1 = Sim.PersonalityTrait.Materialistic,
                    Trait2 = Sim.PersonalityTrait.Glutton,
                    Trait3 = Sim.PersonalityTrait.SelfAssured,
                    Aspiration = Sim.AspirationType.MansionBaron,
                    ImageFileName = "EricLewis.png"
                },
                new Sim()
                {
                    Id = 17,
                    FirstName = "Alice",
                    LastName = "Spencer-Kim",
                    Age = Sim.AgeCategory.YoungAdult,
                    Gender = Sim.GenderType.Female,
                    Trait1 = Sim.PersonalityTrait.LovesOutdoors,
                    Trait2 = Sim.PersonalityTrait.Creative,
                    Trait3 = Sim.PersonalityTrait.Childish,
                    Aspiration = Sim.AspirationType.PainterExtraordinaire,
                    ImageFileName = "AliceSpencer-Kim.png"
                }
            };
            return sims;
        }
    }
}
