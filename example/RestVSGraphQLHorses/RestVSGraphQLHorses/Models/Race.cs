namespace RestVSGraphQLHorses.Models
{
    public class Race
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Track { get; set; }
        public int Distance { get; set; }
        public int Result { get; set; }
        public int HorseId { get; set; }
    }
}