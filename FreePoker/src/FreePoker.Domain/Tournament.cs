/**
 * AKS
 * 2026-2-13
 * Tournament entity.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace FreePoker.Domain

/**
 * AKS
 * 2026-2-13
 * Tournament entity.
 */
{
    public class Tournament : ITournament
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int PlayersCount { get; set; }
        public int startingStack { get; set; }
        public int blindLevelDuration { get; set; }
        public int bigBlindLevelIncrement { get; set; }
        public int smallBlindLevelIncrement { get; set; }

        // Primary user-editable profile: ordered list of segments (rounds and breaks)
        private readonly List<ITournamentSegment> _segments = new();
        public IReadOnlyList<ITournamentSegment> Segments => _segments;

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

        public void AddSegment(ITournamentSegment segment) => _segments.Add(segment);

        public void InsertSegment(int index, ITournamentSegment segment)
        {
            if (index < 0) index = 0;
            if (index >= _segments.Count) _segments.Add(segment);
            else _segments.Insert(index, segment);
        }

        public IEnumerable<Round> GetRounds() => _segments.OfType<Round>();

        public IEnumerable<Break> GetBreaks() => _segments.OfType<Break>();

        public int TotalDurationInMinutes() => _segments.Sum(s => s.DurationInMinutes);
    }
}