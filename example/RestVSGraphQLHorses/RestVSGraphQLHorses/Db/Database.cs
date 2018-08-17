using System.Collections.Generic;
using RestVSGraphQLHorses.Models;

namespace RestVSGraphQLHorses.Db
{
    public class Database
    {
        private static int[] _races = new int[] {1, 2, 3, 4};
        //Printonan Boy
        //The Merry Widow
        //    Luck
        //Bataclan
        //    Gunga Din

        public static Horse PrintonanBoy = new Horse
        {
            Name = "Printonan Boy",
            Birthyear = "",
            Color = "",
            Gender = "",
            Id = 1,
            OwnerId = 1,
            RaceIds = _races
        };

        public static Horse TheMerryWidow = new Horse
        {
            Name = "The Merry Widow",
            Birthyear = "",
            Color = "",
            Gender = "",
            Id = 2,
            OwnerId = 1,
            RaceIds = _races
        };

        public static Horse Luck = new Horse
        {
            Name = "Luck",
            Birthyear = "",
            Color = "",
            Gender = "",
            Id = 3,
            OwnerId = 1,
            RaceIds = _races
        };

        public static Horse Bataclan = new Horse
        {
            Name = "Bataclan",
            Birthyear = "",
            Color = "",
            Gender = "",
            Id = 4,
            OwnerId = 1,
            RaceIds = _races
        };

        public static Horse GungaDin = new Horse
        {
            Name = "Gunga Din",
            Birthyear = "",
            Color = "",
            Gender = "",
            Id = 5,
            OwnerId = 2
        };


        public static List<Horse> GetHorses()
        {
            List<Horse> horses = new List<Horse>();
            horses.Add(PrintonanBoy);
            horses.Add(TheMerryWidow);
            horses.Add(Luck);
            horses.Add(Bataclan);
            horses.Add(GungaDin);
            return horses;
        }

        public static Horse GetHorse(int id)
        {
            switch (id)
            {
                case 1: return PrintonanBoy;
                case 2: return TheMerryWidow;
                case 3: return Luck;
                case 4: return Bataclan;
                case 5: return GungaDin;
                default: return PrintonanBoy;
            }
        }
    }
}