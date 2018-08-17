namespace RestVSGraphQLHorses.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int[] HorseIds { get; set; }
    }
}