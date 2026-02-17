/*
 * AKS
 * 2.17.2026
 * File containing break entity.
 */
using System;

namespace FreePoker.Domain
{
    /**
     * AKS
     * 2.17.2026
     * Break entity, representing a break in the tournament. It has a duration and an optional description.
     */
    public class Break : ITournamentSegment
    {
        public int DurationInMinutes { get; set; }
        public string? Description { get; set; }
        public TournamentSegment SegmentType => TournamentSegment.Break;

        public Break() { }

        public Break(int durationInMinutes, string? description = null)
        {
            DurationInMinutes = durationInMinutes;
            Description = description;
        }
    }
}