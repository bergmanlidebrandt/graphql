namespace RestVSGraphQLHorses.Models
{
    public class Horse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }
        public string Birthyear { get; set; }
        public int OwnerId { get; set; }
        public int TrainerId { get; set; }
        public int[] RaceIds { get; set; }
    }
}