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
        public required string Name { get; set; }
        public int PlayersCount { get; set; }
        public int startingStack { get; set; }
        public int blindLevelDuration { get; set; }
        public int bigBlindLevelIncrement { get; set; }
        public int smallBlindLevelIncrement { get; set; }


        public Tournament()
        {
        }

        public Tournament(int id, string name, int playersCount, int startingStack, int blindLevelDuration, int bigBlindLevelIncrement, int smallBlindLevelIncrement)
        {
            Id = id;
            Name = name;
            PlayersCount = playersCount;
            this.startingStack = startingStack;
            this.blindLevelDuration = blindLevelDuration;
            this.bigBlindLevelIncrement = bigBlindLevelIncrement;
            this.smallBlindLevelIncrement = smallBlindLevelIncrement;
        }
    }
}