using System.Collections.Generic;

namespace FreePoker.Domain
{
    public interface ITournament
    {
        int Id { get; set; }
        string Name { get; set; }
        IReadOnlyList<ITournamentSegment> Segments { get; }

        void AddSegment(ITournamentSegment segment);
        void InsertSegment(int index, ITournamentSegment segment);
        IEnumerable<Round> GetRounds();
        IEnumerable<Break> GetBreaks();
        int TotalDurationInMinutes();
    }
}