using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCharacterCreator.Models
{
    public class Sim
    {
        public enum AgeCategory { Teen, YoungAdult, Adult, Elder }
        public enum GenderType { Male, Female, Other }
        public enum PersonalityTrait {
            Active,
            Cheerful,
            Creative,
            Genius,
            Gloomy,
            Goofball,
            HotHeaded,
            Romantic,
            SelfAssured,
            Unflirty,
            ArtLover,
            Bookworm,
            Foodie,
            Geek,
            MusicLover,
            Perfectionist,
            Ambitious,
            CatLover,
            ChildOfTheIslands,
            ChildOfTheOcean,
            Childish,
            Clumsy,
            DanceMachine,
            DogLover,
            Erratic,
            Glutton,
            Kleptomaniac,
            Lazy,
            LovesOutdoors,
            Materialistic,
            Neat,
            Slob,
            Snob,
            Squeamish,
            Vegetarian,
            Bro,
            Evil,
            FamilyOriented,
            Good,
            HatesChildren,
            Insider,
            Jealous,
            Loner,
            Mean,
            Noncommittal,
            Outgoing,
            Paranoid,
            SelfAbsorbed
        }
        public enum AspirationType
        {
            FriendOfTheAnimals,
            BodyBuilder,
            PainterExtraordinaire,
            MusicalGenius,
            BestsellingAuthor,
            MasterActor,
            MasterActress,
            PublicEnemy,
            ChiefOfMischief,
            SuccessfulLineage,
            BigHappyFamily,
            SuperParent,
            MasterChef,
            MasterMixologist,
            FabulouslyWeathly,
            MansionBaron,
            RenaissanceSim,
            NerdBrain,
            ComputerWhiz,
            SerialRomantic,
            Soulmate,
            CityNative,
            FreelanceBotanist,
            TheCurator,
            AnglingAce,
            OutdoorEnthusiast,
            JokeStar,
            PartyAnimal,
            FriendOfTheWorld,
            LeaderOfThePack
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AgeCategory Age { get; set; }
        public GenderType Gender { get; set; }
        public PersonalityTrait Trait1 { get; set; }
        public PersonalityTrait Trait2 { get; set; }
        public PersonalityTrait Trait3 { get; set; }
        public AspirationType Aspiration { get; set; }
        public string ImageFileName { get; set; }

    }
}
