namespace RestVSGraphQLHorses.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Location { get; set; }
        public int[] HorseIds { get; set; }
    }
}