namespace FreePoker.Domain
{
    public class Round
    {
        public int RoundNumber { get; set; }
        public decimal SmallBlind { get; set; }
        public decimal BigBlind { get; set; }
        public decimal Ante { get; set; }
        public int DurationInMinutes { get; set; }

        public Round()
        {
        }

        public Round(int roundNumber, decimal smallBlind, decimal bigBlind, decimal ante, int durationInMinutes)
        {
            RoundNumber = roundNumber;
            SmallBlind = smallBlind;
            BigBlind = bigBlind;
            Ante = ante;
            DurationInMinutes = durationInMinutes;
        }
    }
}