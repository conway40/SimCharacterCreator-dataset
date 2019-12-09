using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCharacterCreator.Models
{
    public class Sim
    {
        public enum AgeCategory { Teen, [Display(Name="Young Adult")] YoungAdult, Adult, Elder }
        public enum GenderType { Male, Female, Other }
        public enum PersonalityTrait {
            Active,
            Cheerful,
            Creative,
            Genius,
            Gloomy,
            Goofball,
            [Display(Name = "Hot Headed")]
            [Description("Hot Headed")]
            HotHeaded,
            Romantic,
            [Display(Name = "Self Assured")]
            [Description("Self Assured")]
            SelfAssured,
            Unflirty,
            [Display(Name = "Art Lover")]
            [Description("Art Lover")]
            ArtLover,
            Bookworm,
            Foodie,
            Geek,
            [Display(Name = "Music Lover")]
            [Description("Music Lover")]
            MusicLover,
            Perfectionist,
            Ambitious,
            [Display(Name = "Cat Lover")]
            [Description("Cat Lover")]
            CatLover,
            [Display(Name = "Child of the Islands")]
            [Description("Child of the Islands")]
            ChildOfTheIslands,
            [Display(Name = "Child of the Ocean")]
            [Description("Child of the Ocean")]
            ChildOfTheOcean,
            Childish,
            Clumsy,
            [Display(Name = "Dance Machine")]
            [Description("Dance Machine")]
            DanceMachine,
            [Display(Name = "Dog Lover")]
            [Description("Dog Lover")]
            DogLover,
            Erratic,
            Glutton,
            Kleptomaniac,
            Lazy,
            [Display(Name = "Loves Outdoors")]
            [Description("Loves Outdoors")]
            LovesOutdoors,
            Materialistic,
            Neat,
            Slob,
            Snob,
            Squeamish,
            Vegetarian,
            Bro,
            Evil,
            [Display(Name = "Family Oriented")]
            [Description("Family Oriented")]
            FamilyOriented,
            Good,
            [Display(Name = "Hates Children")]
            [Description("Hates Children")]
            HatesChildren,
            Insider,
            Jealous,
            Loner,
            Mean,
            Noncommittal,
            Outgoing,
            Paranoid,
            [Display(Name = "Self Absorbed")]
            [Description("Self Absorbed")]
            SelfAbsorbed
        }
        public enum AspirationType
        {
            [Display(Name = "Friend of the Animals")]
            [Description("Friend of the Animals")]
            FriendOfTheAnimals,
            [Display(Name = "Body Builder")]
            [Description("Body Builder")]
            BodyBuilder,
            [Display(Name = "Painter Extraordinaire")]
            [Description("Painter Extraordinaire")]
            PainterExtraordinaire,
            [Display(Name = "Musical Genius")]
            [Description("Musical Genius")]
            MusicalGenius,
            [Display(Name = "Bestselling Author")]
            [Description("Bestselling Author")]
            BestsellingAuthor,
            [Display(Name = "Master Actor")]
            [Description("Master Actor")]
            MasterActor,
            [Display(Name = "Master Actress")]
            [Description("Master Actress")]
            MasterActress,
            [Display(Name = "Public Enemy")]
            [Description("Public Enemy")]
            PublicEnemy,
            [Display(Name = "Chief of Mischief")]
            [Description("Chief of Mischief")]
            ChiefOfMischief,
            [Display(Name = "Successful Lineage")]
            [Description("Successful Lineage")]
            SuccessfulLineage,
            [Display(Name = "Big Happy Family")]
            [Description("Big Happy Family")]
            BigHappyFamily,
            [Display(Name = "Super Parent")]
            [Description("Super Parent")]
            SuperParent,
            [Display(Name = "Master Chef")]
            [Description("Master Chef")]
            MasterChef,
            [Display(Name = "Master Mixologist")]
            [Description("Master Mixologist")]
            MasterMixologist,
            [Display(Name = "Fabulously Weathly")]
            [Description("Fabulously Weathly")]
            FabulouslyWeathly,
            [Display(Name = "Mansion Baron")]
            [Description("Mansion Baron")]
            MansionBaron,
            [Display(Name = "Renaissance Sim")]
            [Description("Renaissance Sim")]
            RenaissanceSim,
            [Display(Name = "Nerd Brain")]
            [Description("Nerd Brain")]
            NerdBrain,
            [Display(Name = "Computer Whiz")]
            [Description("Computer Whiz")]
            ComputerWhiz,
            [Display(Name = "Serial Romantic")]
            [Description("Serial Romantic")]
            SerialRomantic,
            [Display(Name = "Soulmate")]
            [Description("Soulmate")]
            Soulmate,
            [Display(Name = "City Native")]
            [Description("City Native")]
            CityNative,
            [Display(Name = "Freelance Botanist")]
            [Description("Freelance Botanist")]
            FreelanceBotanist,
            [Display(Name = "The Curator")]
            [Description("The Curator")]
            TheCurator,
            [Display(Name = "Angling Ace")]
            [Description("Angling Ace")]
            AnglingAce,
            [Display(Name = "Outdoor Enthusiast")]
            [Description("Outdoor Enthusiast")]
            OutdoorEnthusiast,
            [Display(Name = "Joke Star")]
            [Description("Joke Star")]
            JokeStar,
            [Display(Name = "Party Animal")]
            [Description("Party Animal")]
            PartyAnimal,
            [Display(Name = "Friend of the World")]
            [Description("Friend of the World")]
            FriendOfTheWorld,
            [Display(Name = "Leader of the Pack")]
            [Description("Leader of the Pack")]
            LeaderOfThePack
        }

        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public AgeCategory Age { get; set; }
        public GenderType Gender { get; set; }

        [Display(Name = "Trait 1")]
        public PersonalityTrait Trait1 { get; set; }

        [Display(Name = "Trait 2")]
        public PersonalityTrait Trait2 { get; set; }

        [Display(Name = "Trait 3")]
        public PersonalityTrait Trait3 { get; set; }

        public AspirationType Aspiration { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Image File Name")]
        public string ImageFileName { get; set; }

    }
}
