namespace FreePoker.Domain

/**
 * AKS
 * 2026-2-13
 * Tournament entity.
 */
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? EndedAt { get; set; }
        public int startingStack { get; set; }
        public int blindLevelDuration { get; set; }
        public int blindLevelIncrement { get; set; }
        public int currentBlindLevel { get; set; }


        public Tournament()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}