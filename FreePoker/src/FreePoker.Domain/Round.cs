namespace FreePoker.Domain
{
    public class Round : ITournamentSegment
    {
        public int RoundNumber { get; set; }
        public decimal SmallBlind { get; set; }
        public decimal BigBlind { get; set; }
        public decimal Ante { get; set; }
        public int DurationInMinutes { get; set; }

        public int durationInMinutes => throw new NotImplementedException();

        public TournamentSegment SegmentType => throw new NotImplementedException();

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