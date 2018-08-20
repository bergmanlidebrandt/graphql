using System.Collections.Generic;
using RestVSGraphQLHorses.Models;

namespace RestVSGraphQLHorses.Db
{
    public class Database
    {
        private static readonly int[] Races = {1, 2, 3, 4};

        public static Race R1 = new Race
        {
            Id = 1,
            Date = "2018-04-01",
            Track = "Bro Park",
            Distance = 10000,
            Result = 1,
            HorseId = 1
        };

        public static Race R2 = new Race
        {
            Id = 2,
            Date = "2018-04-01",
            Track = "Bro Park",
            Distance = 10000,
            Result = 2,
            HorseId = 2
        };

        public static Race R3 = new Race
        {
            Id = 3,
            Date = "2018-04-01",
            Track = "Bro Park",
            Distance = 10000,
            Result = 3,
            HorseId = 3
        };

        public static Race R4 = new Race
        {
            Id = 4,
            Date = "2018-04-01",
            Track = "Bro Park",
            Distance = 10000,
            Result = 4,
            HorseId = 4
        };

        public static Race R5 = new Race
        {
            Id = 5,
            Date = "2018-04-02",
            Track = "Bro Park",
            Distance = 10000,
            Result = 2,
            HorseId = 1
        };

        public static Race R6 = new Race
        {
            Id = 6,
            Date = "2018-04-02",
            Track = "Bro Park",
            Distance = 10000,
            Result = 1,
            HorseId = 2
        };

        public static Race R7 = new Race
        {
            Id = 7,
            Date = "2018-04-02",
            Track = "Bro Park",
            Distance = 10000,
            Result = 3,
            HorseId = 3
        };

        public static Race R8 = new Race
        {
            Id = 8,
            Date = "2018-04-02",
            Track = "Bro Park",
            Distance = 10000,
            Result = 4,
            HorseId = 4
        };

        public static Race R9 = new Race
        {
            Id = 9,
            Date = "2018-04-02",
            Track = "Jägersro Galopp",
            Distance = 15000,
            Result = 3,
            HorseId = 1
        };

        public static Race R10 = new Race
        {
            Id = 10,
            Date = "2018-04-02",
            Track = "Jägersro Galopp",
            Distance = 15000,
            Result = 1,
            HorseId = 2
        };

        public static Race R11 = new Race
        {
            Id = 11,
            Date = "2018-04-02",
            Track = "Jägersro Galopp",
            Distance = 15000,
            Result = 2,
            HorseId = 3
        };

        public static Race R12 = new Race
        {
            Id = 12,
            Date = "2018-04-02",
            Track = "Jägersro Galopp",
            Distance = 15000,
            Result = 4,
            HorseId = 4
        };

        public static Race R13 = new Race
        {
            Id = 13,
            Date = "2018-04-04",
            Track = "Jägersro Galopp",
            Distance = 15000,
            Result = 3,
            HorseId = 1
        };

        public static Race R14 = new Race
        {
            Id = 14,
            Date = "2018-04-04",
            Track = "Jägersro Galopp",
            Distance = 15000,
            Result = 3,
            HorseId = 2
        };

        public static Race R15 = new Race
        {
            Id = 15,
            Date = "2018-04-04",
            Track = "Jägersro Galopp",
            Distance = 15000,
            Result = 1,
            HorseId = 3
        };

        public static Race R16 = new Race
        {
            Id = 16,
            Date = "2018-04-04",
            Track = "Jägersro Galopp",
            Distance = 15000,
            Result = 4,
            HorseId = 4
        };


        public static Horse PrintonanBoy = new Horse
        {
            Name = "Printonan Boy",
            Birthyear = "2015",
            Color = "white",
            Gender = "male",
            Id = 1,
            OwnerId = 1,
            RaceIds = Races
        };

        public static Horse TheMerryWidow = new Horse
        {
            Name = "The Merry Widow",
            Birthyear = "2013",
            Color = "black",
            Gender = "female",
            Id = 2,
            OwnerId = 1,
            RaceIds = Races
        };

        public static Horse Luck = new Horse
        {
            Name = "Luck",
            Birthyear = "2014",
            Color = "brown",
            Gender = "female",
            Id = 3,
            OwnerId = 1,
            RaceIds = Races
        };

        public static Horse Bataclan = new Horse
        {
            Name = "Bataclan",
            Birthyear = "2014",
            Color = "grey",
            Gender = "female",
            Id = 4,
            OwnerId = 1,
            RaceIds = Races
        };

        public static Horse GungaDin = new Horse
        {
            Name = "Gunga Din",
            Birthyear = "2014",
            Color = "black",
            Gender = "male",
            Id = 5,
            OwnerId = 2
        };

        public static Owner O1 = new Owner
        {
            Id = 1,
            Firstname = "Britta",
            Lastname = "Källman",
            HorseIds = new[] {1, 2, 3, 4}
        };

        public static Owner O2 = new Owner
        {
            Id = 2,
            Firstname = "Ulrica",
            Lastname = "Back",
            HorseIds = new[] { 5 }
        };

        public static Trainer T1 = new Trainer
        {
            Id = 1,
            Firstname = "Hanna",
            Lastname = "Hammarlund",
            Location = "Lindesberg",
            HorseIds = new[] {1, 2, 3, 4, 5}
        };


        public static List<Horse> GetHorses()
        {
            var horses = new List<Horse> {PrintonanBoy, TheMerryWidow, Luck, Bataclan, GungaDin};
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

        public static List<Race> GetRaces()
        {
            var races = new List<Race> {R1, R2, R3, R4, R5, R6, R7, R8, R9, R10, R11, R12, R13, R14, R15, R16};
            return races;
        }

        public static Race GetRace(int id)
        {
            switch (id)
            {
                case 1: return R1;
                case 2: return R2;
                case 3: return R3;
                case 4: return R4;
                case 5: return R5;
                case 6: return R6;
                case 7: return R7;
                case 8: return R8;
                case 9: return R9;
                case 10: return R10;
                case 11: return R11;
                case 12: return R12;
                case 13: return R13;
                case 14: return R14;
                case 15: return R15;
                case 16: return R16;
                default: return R1;
            }
        }

        public static List<Owner> GetOwners()
        {
            var owners = new List<Owner> {O1, O2};
            return owners;
        }

        public static Owner GetOwner(int id)
        {
            switch (id)
            {
                case 1: return O1;
                case 2: return O2;
                default: return O1;
            }
        }

        public static List<Trainer> GetTrainers()
        {
            var trainers = new List<Trainer>{T1};
            return trainers;
        }

        public static Trainer GetTrainer(int id)
        {
            switch (id)
            {
                case 1: return T1;
                default: return T1;
            }
        }
    }
}